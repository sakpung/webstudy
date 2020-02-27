﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
#if DNXCORE50
using Leadtools.Data;
#else
using System.Data;
#endif

namespace Leadtools.Medical.AeManagement.DataAccessLayer
{
   public static class Extensions
   {
      public static T GetColumnValue<T>(this IDataReader reader, params string[] columnNames)
      {
         bool foundValue = false;
         T value = default(T);
         IndexOutOfRangeException lastException = null;

         foreach (string columnName in columnNames)
         {
            try
            {
               int ordinal = reader.GetOrdinal(columnName);
               value = (T)reader.GetValue(ordinal);
               foundValue = true;
            }
            catch (IndexOutOfRangeException ex)
            {
               lastException = ex;
            }
         }

         if (!foundValue)
         {
            string message = string.Format("Column(s) {0} could not be not found.",
                    string.Join(", ", columnNames));

            throw new IndexOutOfRangeException(message, lastException);
         }

         return value;
      }
   }
}
