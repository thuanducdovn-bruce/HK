using System;
using System.Windows.Forms;
using System.Resources;

using System.Reflection;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using Insnex.VisionCore;
using Insnex.Vision2D;
using Insnex.Vision2D.Core;
using Insnex.Utility;
using InsWorks.Studio;
using Insnex.Vision2D.Common;
using Insnex.Vision2D.Controls;
using Insnex.Vision2D.ToolBlock;
namespace HK_Inspection
{

    public class Utility
    {
        static public InsRecord TraverseSubRecords(InsRecord r, string[] subs)
        {
            // Utility function to walk down to a specific subrecord
            if (r == null)
                return r;

            foreach (string s in subs)
            {
                if (r.SubRecords.ContainsKey(s))
                    r = r.SubRecords[s];
                else
                    return null;
            }

            return r;
        }
        private delegate void SetControlPropertyThreadSafeDelegate(
            System.Windows.Forms.Control control,
            string propertyName,
            object propertyValue);

        public void SetControlPropertyThreadSafe(
            System.Windows.Forms.Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

        public void SetControlPropertyRecord()
        {
        }
        /*
        public void FlushAllQueues(CogJobManager jm)
        { 
            // Flush all queues
            if (jm == null)
                return;

            jm.UserQueueFlush();
            jm.FailureQueueFlush();
            for (int i = 0; i < jm.JobCount; i++)
            {
                jm.Job(i).OwnedIndependent.RealTimeQueueFlush();
                jm.Job(i).ImageQueueFlush();
            }
        }

        static public int GetJobIndexFromName(CogJobManager mgr, string name)
        {
            if (mgr != null)
            {
                for (int i = 0; i < mgr.JobCount; ++i)
                    if (mgr.Job(i).Name == name)
                        return i;
            }
            return -1;
        }
        */
        public System.Type GetPropertyType(object obj, string path)
        {
            if (obj == null || string.IsNullOrEmpty(path))
                return null;

            System.Type currentType = obj.GetType();
            foreach (string memberName in path.Split('.'))
            {
                var property = currentType.GetProperty(memberName,
                    BindingFlags.Instance | BindingFlags.Public);
                if (property != null)
                {
                    currentType = property.PropertyType;
                    continue;
                }

                var field = currentType.GetField(memberName,
                    BindingFlags.Instance | BindingFlags.Public);
                if (field == null)
                    return null;
                currentType = field.FieldType;
            }

            return currentType;
        }

        public void SetupPropertyProvider(object propertyProvider, Control gui, string path)
        {
            if (propertyProvider == null)
                throw new System.ArgumentNullException("propertyProvider");

            propertyProvider.GetType().InvokeMember("SetPath", BindingFlags.InvokeMethod,
                null, propertyProvider, new object[] { gui, path });
        }

        public bool AddRecordToDisplay(InsDisplay disp, InsRecord r, string[] subs,
            bool pickBestImage)
        {
            if (disp == null)
                return false;

            InsRecord record = TraverseSubRecords(r, subs);
            if (record == null)
                return false;

            bool recordAssigned = false;
            foreach (var property in disp.GetType().GetProperties())
            {
                if (property.CanWrite && property.PropertyType.IsAssignableFrom(typeof(InsRecord)) &&
                    property.Name.IndexOf("Record", System.StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    property.SetValue(disp, record, null);
                    recordAssigned = true;
                    break;
                }
            }

            if (pickBestImage)
            {
                for (int i = 0; i < record.SubRecords.Count; i++)
                {
                    InsRecord subRecord = record.SubRecords[i];
                    IInsImage image = subRecord.Content as IInsImage;
                    if (image == null || image.Width == 0 || image.Height == 0)
                        continue;

                    foreach (var property in disp.GetType().GetProperties())
                    {
                        if (property.CanWrite && property.PropertyType.IsAssignableFrom(image.GetType()))
                        {
                            property.SetValue(disp, image, null);
                            return true;
                        }
                    }
                    break;
                }
            }

            return recordAssigned;
        }
        /*
        public InsToolBase EditTool
        {
            get => insToolEditorControl1.Subject;
            set => insToolEditorControl1.Subject = value;
        }
        public void SaveJobFile(string VppFileName, InsToolBlock job)
        {

            // save the QuickBuild project file
            var dlg = new SaveFileDialog();
            dlg.Filter = "InsWorks tolb file|*.tolb";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                InsUtils.SaveObjectToFile(EditTool, dlg.FileName);
            }



        }
        */


        //public static string GetThisExecutableDirectory()
        //{
        //  string loc = Application.ExecutablePath;
        //  loc = System.IO.Path.GetDirectoryName(loc) + "\\";
        //  return loc;
        //}
        //    public Bitmap getBitmapImage(IImage inputImage, IImage overlayImage)
        //    {
        //        Bitmap mergedBitmap = null;
        //        try
        //        {
        //            var bitmapLocated = inputImage.Bitmap;
        //            var bitmapLocatedOverlay = overlayImage.Bitmap;

        //            mergedBitmap = MergeBitmap(bitmapLocated, bitmapLocatedOverlay);
        //        }
        //        catch { }




        //        return mergedBitmap;
        //    }
        //    public Bitmap MergeBitmap(Bitmap inputBitmap, Bitmap mergeBitmap)
        //    {
        //        // The original bitmap with the wrong pixel format. 
        //        // You can check the pixel format with originalBmp.PixelFormat


        //        // Create a blank bitmap with the same dimensions
        //        Bitmap tempBitmap = new Bitmap(inputBitmap.Width, inputBitmap.Height);

        //        // From this bitmap, the graphics can be obtained, because it has the right PixelFormat
        //        using (Graphics g = Graphics.FromImage(tempBitmap))
        //        {
        //            // Draw the original bitmap onto the graphics of the new bitmap
        //            g.DrawImage(inputBitmap, 0, 0);
        //            // Use g to do whatever you like
        //            try
        //            {
        //                g.DrawImage(mergeBitmap, 0, 0);
        //            }
        //            catch { }


        //        }
        //        return tempBitmap;
        //    }

        public Bitmap DrawRectangle(Bitmap inputBitmap, List<Dictionary<string, int>> Coor)
        {
            // The original bitmap with the wrong pixel format. 
            // You can check the pixel format with originalBmp.PixelFormat






            // Create a blank bitmap with the same dimensions
            Bitmap tempBitmap = new Bitmap(inputBitmap.Width, inputBitmap.Height);

            // From this bitmap, the graphics can be obtained, because it has the right PixelFormat
            using (Graphics g = Graphics.FromImage(tempBitmap))
            {
                // Draw the original bitmap onto the graphics of the new bitmap
                g.DrawImage(inputBitmap, 0, 0);
                // Use g to do whatever you like
                try
                {
                    for (int i = 0; i < Coor.Count; i++)
                    {
                        Color customColor;
                        if (Coor[i]["passFail"] == 0)
                            customColor = Color.Red;
                        else
                            customColor = Color.Green;
                        Pen drawPen = new Pen(customColor, 10);
                        g.DrawRectangle(drawPen, Coor[i]["PosX"], Coor[i]["PosY"], Coor[i]["Width"], Coor[i]["Height"]);
                    }


                }
                catch { }


            }
            return tempBitmap;
        }
        #region Microsoft Excel
        /*
        public void LogExcel(string excelPath, string modelName, string resCam1, string resCam2, string resCam3, string resTotal, string imagePath1, string imagePath2, string imagePath3)
        {
            try
            {
                if (!File.Exists(excelPath))
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("Sheet1");
                    IRow row0 = sheet.CreateRow(0);
                    IRow row1 = sheet.CreateRow(1);

                    row0.CreateCell(0).SetCellValue("No");
                    row0.CreateCell(1).SetCellValue("DATE TIME");
                    row0.CreateCell(2).SetCellValue("CODE");
                    row0.CreateCell(3).SetCellValue("D1");
                    row0.CreateCell(4).SetCellValue("D2");
                    row0.CreateCell(5).SetCellValue("D3");
                    row0.CreateCell(6).SetCellValue("D4");
                    row0.CreateCell(7).SetCellValue("D5");
                    row0.CreateCell(8).SetCellValue("D6");
                    row0.CreateCell(9).SetCellValue("OK");
                    row0.CreateCell(10).SetCellValue("NG");

                    row1.CreateCell(0);
                    row1.CreateCell(1);

                    FileStream create = File.Create(excelPath);
                    workbook.Write(create);

                    create.Close();

                    LogExcelAppend(excelPath, modelName, resCam1, resCam2, resCam3, resTotal, imagePath1, imagePath2, imagePath3);
                }
                else
                {
                    LogExcelAppend(excelPath, modelName, resCam1, resCam2, resCam3, resTotal, imagePath1, imagePath2, imagePath3);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void LogExcelAppend(string excelPath, string code, string d1, string d2, string d3, string d4, string d5, string d6, string result)
        {
            try
            {
                FileStream fsApp = new FileStream(excelPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                IWorkbook workbook = new XSSFWorkbook(fsApp);
                ISheet sheet = workbook.GetSheetAt(0);

                if (sheet.GetRow(1).GetCell(1).StringCellValue.ToLower() != "")
                    sheet.ShiftRows(1, sheet.LastRowNum, 1);

                IRow row1 = sheet.CreateRow(1);

                row1.CreateCell(0).SetCellValue(sheet.LastRowNum);            
                row1.CreateCell(1).SetCellValue(DateTime.Now.ToString("dd/MM/yyyy HH_mm_ss"));
                row1.CreateCell(2).SetCellValue(code);
                row1.CreateCell(3).SetCellValue(d1);
                row1.CreateCell(4).SetCellValue(d2);
                row1.CreateCell(5).SetCellValue(d3);
                row1.CreateCell(6).SetCellValue(d4);
                row1.CreateCell(7).SetCellValue(d5);
                row1.CreateCell(8).SetCellValue(d6);
                if (result == "True")
                {
                    row1.CreateCell(9).SetCellValue(result);
                    row1.CreateCell(10).SetCellValue("");
                }
                else if (result == "False")
                {
                    row1.CreateCell(9).SetCellValue("");
                    row1.CreateCell(10).SetCellValue(result);
                }

                sheet.AutoSizeColumn(0);
                sheet.AutoSizeColumn(1);
                sheet.AutoSizeColumn(2);
                sheet.AutoSizeColumn(3);
                sheet.AutoSizeColumn(4);
                sheet.AutoSizeColumn(5);
                sheet.AutoSizeColumn(6);
                sheet.AutoSizeColumn(7);
                sheet.AutoSizeColumn(8);
                sheet.AutoSizeColumn(9);
                sheet.AutoSizeColumn(10);

                FileStream fout = new FileStream(excelPath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                fout.Flush();
                workbook.Write(fout);
                fout.Close();
            }
            catch (Exception)
            {
                
            }
        }
        */
        public string ChildPathDefine(string root, string modelName, bool excel)
        {
            string path = root;

            path = Path.Combine(path, DateTime.Now.ToString("yyyy-MM"));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(path, DateTime.Now.ToString("dd"));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(path, modelName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            
            if(excel)
                path = Path.Combine(path, modelName + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".xlsx");
            else
            {
                path = Path.Combine(path, "images");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            return path;
        }
        #endregion

    }


}
