﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************

using System.Runtime.Serialization;

namespace Leadtools.Document.Service
{
   [DataContract]
   public enum RasterImageFormat
   {
      Unknown = 0,
      Pcx = 1,
      Gif = 2,
      Tif = 3,
      Tga = 4,
      Cmp = 5,
      Bmp = 6,
      Jpeg = 10,
      TifJpeg = 11,
      Os2 = 14,
      Wmf = 15,
      Eps = 16,
      TifLzw = 17,
      Jpeg411 = 21,
      TifJpeg411 = 22,
      Jpeg422 = 23,
      TifJpeg422 = 24,
      Ccitt = 25,
      Lead1Bit = 26,
      CcittGroup31Dim = 27,
      CcittGroup32Dim = 28,
      CcittGroup4 = 29,
      Abc = 32,
      Cals = 50,
      Mac = 51,
      Img = 52,
      Msp = 53,
      Wpg = 54,
      Ras = 55,
      Pct = 56,
      Pcd = 57,
      Dxf = 58,
      Dxf12 = 58,
      Fli = 61,
      Cgm = 62,
      EpsTiff = 63,
      EpsWmf = 64,
      FaxG31Dim = 66,
      FaxG32Dim = 67,
      FaxG4 = 68,
      WfxG31Dim = 69,
      WfxG4 = 70,
      IcaG31Dim = 71,
      IcaG32Dim = 72,
      IcaG4 = 73,
      Os22 = 74,
      Png = 75,
      Psd = 76,
      RawIcaG31Dim = 77,
      RawIcaG32Dim = 78,
      RawIcaG4 = 79,
      Fpx = 80,
      FpxSingleColor = 81,
      FpxJpeg = 82,
      FpxJpegQFactor = 83,
      BmpRle = 84,
      TifCmyk = 85,
      TifLzwCmyk = 86,
      TifPackBits = 87,
      TifPackBitsCmyk = 88,
      DicomGray = 89,
      DicomColor = 90,
      WinIco = 91,
      WinCur = 92,
      TifYcc = 93,
      TifLzwYcc = 94,
      TifPackbitsYcc = 95,
      Exif = 96,
      ExifYcc = 97,
      ExifJpeg = 98,
      ExifJpeg422 = 98,
      Awd = 99,
      ExifJpeg411 = 101,
      PbmAscii = 102,
      PbmBinary = 103,
      PgmAscii = 104,
      PgmBinary = 105,
      PpmAscii = 106,
      PpmBinary = 107,
      Cut = 108,
      Xpm = 109,
      Xbm = 110,
      IffIlbm = 111,
      IffCat = 112,
      Xwd = 113,
      Clp = 114,
      Jbig = 115,
      Emf = 116,
      IcaIbmMmr = 117,
      RawIcaIbmMmr = 118,
      Ani = 119,
      LaserData = 121,
      IntergraphRle = 122,
      IntergraphVector = 123,
      Dwg = 124,
      DicomRleGray = 125,
      DicomRleColor = 126,
      DicomJpegGray = 127,
      DicomJpegColor = 128,
      Cals4 = 129,
      Cals2 = 130,
      Cals3 = 131,
      Xwd10 = 132,
      Xwd11 = 133,
      Flc = 134,
      Kdc = 135,
      Drw = 136,
      Plt = 137,
      TifCmp = 138,
      TifJbig = 139,
      TifDxf = 140,
      TifUnknown = 141,
      Sgi = 142,
      SgiRle = 143,
      Dwf = 145,
      RasPdf = 146,
      RasPdfG31Dim = 147,
      RasPdfG32Dim = 148,
      RasPdfG4 = 149,
      RasPdfJpeg = 150,
      RasPdfJpeg422 = 151,
      RasPdfJpeg411 = 152,
      Raw = 153,
      TifCustom = 155,
      RawRgb = 156,
      RawRle4 = 157,
      RawRle8 = 158,
      RawBitfields = 159,
      RawPackBits = 160,
      RawJpeg = 161,
      RawCcitt = 162,
      FaxG31DimNoEol = 162,
      Jp2 = 163,
      J2k = 164,
      Cmw = 165,
      TifJ2k = 166,
      TifCmw = 167,
      Mrc = 168,
      Gerber = 169,
      Wbmp = 170,
      JpegLab = 171,
      JpegLab411 = 172,
      JpegLab422 = 173,
      GeoTiff = 174,
      TifLead1Bit = 175,
      TifMrc = 177,
      RawLzw = 178,
      RasPdfLzw = 179,
      TifAbc = 180,
      Nap = 181,
      JpegRgb = 182,
      Jbig2 = 183,
      RawIcaAbic = 184,
      Abic = 185,
      TifAbic = 186,
      TifJbig2 = 187,
      RasPdfJbig2 = 188,
      TifZip = 189,
      IcaAbic = 190,
      AfpIcaAbic = 191,
      Postscript = 222,
      Svg = 247,
      Ptoca = 249,
      Sct = 250,
      Pcl = 251,
      Afp = 252,
      IcaUncompressed = 253,
      RawIcaUncompressed = 254,
      Shp = 255,
      Smp = 256,
      SmpG31Dim = 257,
      SmpG32Dim = 258,
      SmpG4 = 259,
      Cmx = 261,
      TgaRle = 262,
      Kdc120 = 263,
      Kdc40 = 264,
      Kdc50 = 265,
      Dcs = 266,
      TifxJbig = 269,
      TifxJbigT43 = 270,
      TifxJbigT43ItuLab = 271,
      TifxJbigT43Gs = 272,
      TifxFaxG4 = 273,
      TifxFaxG31D = 274,
      TifxFaxG32D = 275,
      TifxJpeg = 276,
      RasRle = 288,
      Dxf13 = 290,
      ClpRle = 291,
      Dcr = 292,
      DicomJ2kGray = 293,
      DicomJ2kColor = 294,
      Fit = 295,
      Crw = 296,
      DwfTextAsPolyline = 297,
      Cin = 298,
      EpsPostscript = 300,
      IntergraphCcittG4 = 301,
      Sff = 302,
      IffIlbmUncompressed = 303,
      IffCatUncompressed = 304,
      RtfRaster = 305,
      Wmz = 307,
      AfpIcaG31Dim = 309,
      AfpIcaG32Dim = 310,
      AfpIcaG4 = 311,
      AfpIcaUncompressed = 312,
      AfpIcaIbmMmr = 313,
      LeadMrc = 314,
      TifLeadMrc = 315,
      Txt = 316,
      PdfLeadMrc = 317,
      Hdp = 318,
      HdpGray = 319,
      HdpCmyk = 320,
      PngIco = 321,
      Xps = 322,
      Jpx = 323,
      XpsJpeg = 324,
      XpsJpeg422 = 325,
      XpsJpeg411 = 326,
      Mng = 327,
      MngGray = 329,
      MngJng = 330,
      MngJng411 = 331,
      MngJng422 = 332,
      RasPdfCmyk = 333,
      RasPdfLzwCmyk = 334,
      Mif = 335,
      E00 = 336,
      Tdb = 337,
      Tdb2 = 338,
      Snp = 339,
      AfpIm1 = 340,
      Xls = 341,
      Doc = 342,
      Anz = 343,
      Ppt = 344,
      PptJpeg = 345,
      PptPng = 346,
      Jpm = 347,
      Vff = 348,
      PclXl = 349,
      Docx = 350,
      Xlsx = 351,
      Pptx = 352,
      Jxr = 353,
      JxrGray = 354,
      JxrCmyk = 355,
      Jls = 356,
      Jxr422 = 357,
      Jxr420 = 358,
      DcfArw = 359,
      DcfRaf = 360,
      DcfOrf = 361,
      DcfCr2 = 362,
      DcfNef = 363,
      DcfRw2 = 364,
      DcfCasio = 365,
      DcfPentax = 366,
      JlsLine = 367,
      JlsSample = 368,
      Htm = 369,
      Mob = 370,
      Pub = 371,
      Ing = 372,
      IngRle = 373,
      IngAdaptiveRle = 374,
      IngG4 = 375,
      Dwfx = 376,
      IcaJpeg = 377,
      IcaJpeg411 = 378,
      IcaJpeg422 = 379,
      DcfDng = 380,
      RawFlate = 381,
      RawRle = 382,
      DicomJlsGray = 383,
      DicomJlsColor = 384,
      Pst = 385,
      Msg = 386,
      Eml = 387,
      RasPdfJpx = 388,
      DicomJpxGray = 389,
      DicomJpxColor = 390,
      JpegCmyk = 391,
      JpegCmyk411 = 392,
      JpegCmyk422 = 393,
      TifJpegCmyk = 394,
      TifJpegCmyk411 = 395,
      TifJpegCmyk422 = 396,
      Svgz = 397,
      X9f = 398,
      ThreeJS = 399,
      Stl = 400
   }
}
