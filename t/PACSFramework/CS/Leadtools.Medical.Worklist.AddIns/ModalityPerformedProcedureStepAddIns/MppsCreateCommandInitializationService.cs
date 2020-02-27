﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leadtools.Dicom ;
using Leadtools.Dicom.AddIn.Configuration ;
using Leadtools.Dicom.Scp.Command ;
using Leadtools.Dicom.Scp.Command.Configuration ;
using Leadtools.Medical.Worklist.AddIns.Configuration ;
using Leadtools.Logging ;
using Leadtools.Logging.Medical;


namespace Leadtools.Medical.Worklist.AddIns
{
   class MppsCreateCommandInitializationService : IInitializationService
   {
      #region IInitializationService Members

      public void ConfigureCommand ( DicomCommand command )
      {
         try
         {
            AdvancedSettings settings ;
            WorklistAddInsConfiguration worklistConfig ;
            
            settings       = AdvancedSettings.Open ( AddInsSession.ServiceDirectory ) ;
            worklistConfig = GetWorklistAddInsSettings ( settings ) ;

            
            
            if ( null != settings ) 
            {
               if ( command is NCreateCommand )
               {
                  ConfigureNCreateCommand ( command, worklistConfig ) ;
               }
               
               if ( command is MppsNCreateCommand )
               {
                  ConfigureMppsNCreateCommand ( command, worklistConfig ) ;
               }

            }
         }
         catch ( Exception exception ) 
         {
            LogEvent ( "Failed to configure Modality Performed Procedure NCreate Command, default configuration will be applied.^\n" + exception.Message, command.RequestDataSet ) ;
         }
      }

      private static void ConfigureNCreateCommand 
      ( 
         DicomCommand command, 
         WorklistAddInsConfiguration worklistConfig 
      )
      {
         NCreateCommand createCommand ;
         
         
         createCommand = command as NCreateCommand ;
         
         if ( null != createCommand ) 
         {
            createCommand.Configuration.AllowExtraElements   = worklistConfig.ModalityPerformedProcedureCreateValidation.AllowExtraElements ;
            createCommand.Configuration.AllowPrivateElements = worklistConfig.ModalityPerformedProcedureCreateValidation.AllowPrivateElements ;
         }
      }
      
      private static void ConfigureMppsNCreateCommand 
      ( 
         DicomCommand command, 
         WorklistAddInsConfiguration worklistConfig 
      )
      {
         MppsNCreateCommand mppsCreateCommand ;
         
         
         mppsCreateCommand = command as MppsNCreateCommand ;
         
         if ( null != mppsCreateCommand )
         {
            mppsCreateCommand.PPSConfiguration.ModalityPerformedProcedureStepIODPath      = worklistConfig.ModaliyPerformedProcedureCreateIODPath ;
            mppsCreateCommand.PPSConfiguration.ValidateRelationalAttributesAccordingToIHE = worklistConfig.ModalityPerformedProcedureCreateValidation.ValidateRelationalToIHERules ;
         }
      }

      #endregion
      
      private static WorklistAddInsConfiguration GetWorklistAddInsSettings
      (
         AdvancedSettings advancedSettings
      )
      {
         WorklistAddInsConfiguration settings;
         string addInsName ;
         
         
         addInsName = System.Reflection.Assembly.GetExecutingAssembly ( ).GetName ( ).Name ;
         
         settings = advancedSettings.GetAddInCustomData <WorklistAddInsConfiguration> ( addInsName, 
                                                                                        WorklistAddInsConfiguration.SectionName ) ;
         if ( null == settings ) 
         {
            settings = new WorklistAddInsConfiguration ( ) ;
         }
         
         return settings;
      }
      
      private static void LogEvent ( string message, DicomDataSet dataset )
      {
         try
         {
            Logger.Global.Log ( AddInsSession.ServerAE, 
                                AddInsSession.ServerAddress, 
                                AddInsSession.ServerPort, 
                                string.Empty, 
                                string.Empty, 
                                -1, 
                                DicomCommandType.NCreate,
                                DateTime.Now, 
                                LogType.Error, 
                                MessageDirection.Input,
                                message,
                                dataset,
                                null ) ;
         }
         catch ( Exception ) 
         {}
      }
   }
}
