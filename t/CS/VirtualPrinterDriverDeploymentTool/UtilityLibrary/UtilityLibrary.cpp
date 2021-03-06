// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
// UtilityLibrary.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

// Check if the a printer driver is installed with the given name and environment
extern "C" _declspec(dllexport) DWORD CheckIfPrinterDriverInstalled(LPTSTR pEnvironment, LPTSTR pDriverName)
{
   DWORD cbNeeded = 0;
   DWORD cReturned = 0;
   if (EnumPrinterDrivers(NULL, pEnvironment, 1, NULL, 0, &cbNeeded, &cReturned))
      // Succeeds, but shouldn't, because buffer is zero (too small)!
      return ERROR_BAD_LENGTH;

   // Ensure it was an insufficient buffer error
   DWORD result = GetLastError();
   if (result != ERROR_INSUFFICIENT_BUFFER)
      return result;

   // Allocate the required size
   result = ERROR_NOT_SUPPORTED;
   DWORD cbBuf = cbNeeded;
   BYTE* pDriverInfo = new BYTE[cbBuf];

   // Get all the printers
   if (!EnumPrinterDrivers(NULL, pEnvironment, 1, pDriverInfo, cbBuf, &cbNeeded, &cReturned))
   {
      result = GetLastError();
      goto cleanup;
   }

   // Check for the printer driver names
   {
      DRIVER_INFO_1* info;
      BYTE* offset = pDriverInfo;
      int increment = sizeof(DRIVER_INFO_1);
      for (DWORD i = 0; i < cReturned; i++)
      {
         info = (DRIVER_INFO_1*)offset;
#ifdef UNICODE
         if (wcscmp(info->pName, pDriverName) == 0)
            return S_OK;
#else
         if (strcmp(info->pName, pDriverName) == 0)
            return S_OK;
#endif
         offset += increment;
      }
   }

   // Finished but not found
   result = ERROR_UNKNOWN_PRINTER_DRIVER;

cleanup:
   // Free space
   delete[] pDriverInfo;
   return result;
}