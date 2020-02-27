﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using Leadtools.Medical.WebViewer.DataContracts;
using Leadtools.DataAccessLayers.Core;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using Leadtools.Medical.WebViewer.Services.Interfaces;
using Leadtools.Medical.WebViewer.Errors;
using Leadtools.Medical.WebViewer.Common;
using Leadtools.Medical.WebViewer.ServiceContracts;

namespace Leadtools.Medical.WebViewer.Services.Implementation
{
   public class TemplateHandler : ITemplateHandler
   {
      ITemplateAddin _addin;


      public TemplateHandler(AddinsFactory factory)
      {
         _addin = factory.CreateTemplateAddin();
      }

      public List<AnatomicDescription> GetAnatomicDescriptions(string authenticationCookie, string userData)
      {
         try
         {
            string userName;


            userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanViewTemplates);

            return _addin.GetAnatomicDescriptions(userData);
         }
         catch (ServiceAuthorizationException)
         {
            throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            throw new ServiceException(e.Message, HttpStatusCode.InternalServerError);
         }
      }

      public List<WCFTemplate> GetAllTemplates(string authenticationCookie, string userData)
      {
         try
         {
            string userName;


            userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanViewTemplates);

            return _addin.GetAllTemplates(userData);
         }
         catch (ServiceAuthorizationException)
         {
            throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            throw new ServiceException(e.Message, HttpStatusCode.InternalServerError);
         }
      }


      public void AddTemplate(string authenticationCookie, WCFTemplate template, string userData)
      {
         try
         {
            string userName;


            userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanAddTemplates);

            _addin.AddTemplate(userName, template, userData);
         }
         catch (ServiceAuthorizationException)
         {
            throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            throw new WebException(e.Message, e.InnerException);
         }
      }

      public void UpdateTemplate(string authenticationCookie, WCFTemplate template, string userData)
      {
         try
         {
            string userName;


            userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanEditTemplates);

            _addin.UpdateTemplate(userName, template, userData);
         }
         catch (ServiceAuthorizationException)
         {
            throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            throw new ServiceException(e.Message, HttpStatusCode.InternalServerError);
         }
      }

      public void DeleteTemplate(string authenticationCookie, string templateId, string userData)
      {
         try
         {
            string userName;


            userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanDeleteTemplates);

            _addin.DeleteTemplate(userName, templateId, userData);
         }
         catch (ServiceAuthorizationException)
         {
            throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            throw new ServiceException(e.Message, HttpStatusCode.InternalServerError);
         }
      }

      public Stream ExportAllTemplates(string authenticationCookie, string userData)
      {
         string userName;
         List<WCFTemplate> templates;
         DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<WCFTemplate>));
         MemoryStream stream;


         userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanExportTemplates);

         templates = _addin.GetAllTemplates(userData);
         stream = new MemoryStream();
         serializer.WriteObject(stream, templates);
         stream.Position = 0;

         return stream;
      }

      private List<WCFTemplate> GetImportTemplatesError(string errorMessage)
      {
         const string errorGuid = "GetImportTemplatesError_0F649AC6-0D07-49EA-906C-413256B8A43E";
         WCFTemplate template = new WCFTemplate();
         template.Id = errorGuid;
         template.Name = errorMessage;
         List<WCFTemplate> list = new List<WCFTemplate> { template };
         return list;
      }

      public void UpdateTemplateIds(WCFTemplate template)
      {
         if (string.IsNullOrEmpty(template.Id))
         {
            Guid guid = System.Guid.NewGuid();
            template.Id = guid.ToString();
         }

         foreach (TemplateFrame frame in template.Frames)
         {
            if (string.IsNullOrEmpty(frame.Id))
            {
               frame.Id = Guid.NewGuid().ToString();
            }
         }
      }

      public List<WCFTemplate> ImportTemplates(Stream file)
      {
         List<WCFTemplate> returnTemplateList = new List<WCFTemplate>();

         try
         {
            HttpMultipartParser parser = new HttpMultipartParser(file, "file");

            if (parser.Success)
            {
               string authenticationCookie = parser.Parameters["auth"];

               string userName = AuthHandler.Authorize(authenticationCookie, PermissionsTable.Instance.CanImportTemplates);

               if (parser.FileContents.Length > 0)
               {
                  string jsonString = ParseTools.ToString(parser.FileContents);
                  DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<WCFTemplate>));

                  using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
                  {
                     List<WCFTemplate> templates = serializer.ReadObject(ms) as List<WCFTemplate>;

                     if (templates != null)
                     {
                        foreach (WCFTemplate template in templates)
                        {
                           UpdateTemplateIds(template);
                           _addin.UpdateTemplate(userName, template, string.Empty);
                        }
                     }
                     return templates;
                  }
               }
            }
         }
         catch (ServiceAuthorizationException)
         {
            returnTemplateList = GetImportTemplatesError("Access denied, please login with different user to have this feature available.");
            // throw new ServiceAuthorizationException("Access denied, please login with different user to have this feature available.");
         }
         catch (Exception e)
         {
            returnTemplateList = GetImportTemplatesError(e.Message);
         }

         return returnTemplateList;
      }
   }
}
