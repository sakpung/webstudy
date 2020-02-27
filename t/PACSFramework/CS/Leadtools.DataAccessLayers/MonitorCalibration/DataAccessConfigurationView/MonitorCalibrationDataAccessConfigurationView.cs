﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leadtools.Medical.DataAccessLayer.Configuration;

namespace Leadtools.DataAccessLayers
{
   public class MonitorCalibrationDataAccessConfigurationView : DataAccessConfigurationView
   {
      private static readonly DataAccessMapping defaultSqlMapping   = new DataAccessMapping(DataAccessMapping.DefaultSqlProviderName, typeof(MonitorCalibrationSqlDataAccessAgent), null);
      private static readonly DataAccessMapping defaultSqlCeMapping = new DataAccessMapping(DataAccessMapping.DefaultSqlCe3_5ProviderName, typeof(MonitorCalibrationSqlCeDataAccessAgent), null);

      public MonitorCalibrationDataAccessConfigurationView()
         : base()
      { }

      public MonitorCalibrationDataAccessConfigurationView(System.Configuration.Configuration configuration, string productName, string serviceName)
         : base(configuration, productName, serviceName)
      { }

      public override string DataAccessSettingsSectionName
      {
         get 
         {
#if LTV17_CONFIG
            return "monitorCalibrationConfiguration" ; 
#endif
#if LTV175_CONFIG

            return "monitorCalibrationConfiguration175";
#endif  
#if LTV18_CONFIG

            return "monitorCalibrationConfiguration18";
#endif
#if LTV19_CONFIG
            return "monitorCalibrationConfiguration19";
#endif
#if LTV20_CONFIG
            return "monitorCalibrationConfiguration20";
#endif
         }
      }

      protected override DataAccessMapping GetDefaultMapping ( string name, string dbProviderName )
      {
         // try to short circuit by default name
         if (DataAccessMapping.DefaultSqlProviderName.Equals(dbProviderName))
            return defaultSqlMapping;


         if (DataAccessMapping.DefaultSqlCe3_5ProviderName.Equals(dbProviderName))
            return defaultSqlCeMapping;
         
         return null;
      }
   }
}
