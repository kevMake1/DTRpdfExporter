using DTR.ViewModel.Commands;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DTR.ViewModel
{
    public class DTRInternationalVM : INotifyPropertyChanged
    {
        //Property changed boiler -------------------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Vars --------------------------------------------------------------------------------------------
        private string shipperExporter;

        public string ShipperExporter
        {
            get { return shipperExporter; }
            set { shipperExporter = value; OnPropertyChanged("ShipperExporter");}
        }

        private string bookingNumber;

        public string BookingNumber
        {
            get { return bookingNumber; }
            set { bookingNumber = value; OnPropertyChanged("BookingNumber"); }
        }

        private string billOfLanding;

        public string BillOfLanding
        {
            get { return billOfLanding; }
            set { billOfLanding = value; OnPropertyChanged("BillOfLanding"); }
        }

        private string cosignee;

        public string Cosignee
        {
            get { return cosignee; }
            set { cosignee = value; OnPropertyChanged("Cosignee"); }
        }

        private string exportRef;

        public string ExportRef
        {
            get { return exportRef; }
            set { exportRef = value; OnPropertyChanged("ExportRef"); }
        }

        private string forwardingAgent;

        public string ForwardingAgent
        {
            get { return forwardingAgent; }
            set { forwardingAgent = value; OnPropertyChanged("FowardingAgent"); }
        }

        private string pointAndCountry;

        public string PointAndCountry
        {
            get { return pointAndCountry; }
            set { pointAndCountry = value; OnPropertyChanged("PointAndCountry"); }
        }

        private string notify;

        public string Notify
        {
            get { return notify; }
            set { notify = value; OnPropertyChanged("Notify"); }
        }

        private string alsoNotify;

        public string AlsoNotify
        {
            get { return alsoNotify; }
            set { alsoNotify = value; OnPropertyChanged("AlsoNotify"); }
        }

        private string initialCarriage;

        public string InitialCarriage
        {
            get { return initialCarriage; }
            set { initialCarriage = value; OnPropertyChanged("InitialCarriage"); }
        }

        private string loadingVessel;

        public string LoadingVessel
        {
            get { return loadingVessel; }
            set { loadingVessel = value; OnPropertyChanged("LoadingVessel"); }
        }

        private string portOfDischarge;

        public string PortOfDischarge
        {
            get { return portOfDischarge; }
            set { portOfDischarge = value; OnPropertyChanged("PortOfDischarge"); }
        }

        private string placeOfReceipt;

        public string PlaceOfReceipt
        {
            get { return placeOfReceipt; }
            set { placeOfReceipt = value; OnPropertyChanged("PlaceOfReceipt"); }
        }

        private string portOfLoading;

        public string PortOfLoading
        {
            get { return portOfLoading; }
            set { portOfLoading = value; OnPropertyChanged("PortOfLoading"); }
        }

        private string placeOfDelivery;

        public string PlaceOfDelivery
        {
            get { return placeOfDelivery; }
            set { placeOfDelivery = value; OnPropertyChanged("PlaceOfDelivery"); }
        }

        private string furtherRouting;

        public string FurtherRouting
        {
            get { return furtherRouting; }
            set { furtherRouting = value; OnPropertyChanged("FurtherRouting"); }
        }

        private string mks;

        public string Mks
        {
            get { return mks; }
            set { mks = value; OnPropertyChanged("Mks"); }
        }

        private string pks;

        public string Pks
        {
            get { return pks; }
            set { pks = value; OnPropertyChanged("Pks"); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        private string grossWeight;

        public string GrossWeight
        {
            get { return grossWeight; }
            set { grossWeight = value; OnPropertyChanged("GrossWeight"); }
        }

        private string mesurement;

        public string Mesurement
        {
            get { return mesurement; }
            set { mesurement = value; OnPropertyChanged("Mesurement"); }
        }









        //Constructor and Commands -----------------------------------------------------------------------------------------
        public PrintCommand printCommand { get; set; }
        public ExportCommand exportCommand { get; set; }
        public XParagraphAlignment XParagraphAlignmentleft { get; private set; }

        public DTRInternationalVM()
        {
            printCommand = new PrintCommand(this);
            exportCommand = new ExportCommand(this);
            //ShipperExporter = "test\nfdsf";
            //ExportToPdf();
            
        }

        //Methods ------------------------------------------------------------------------------------------
        public void PrintToConsole() //debug
        {
            Console.WriteLine(ShipperExporter);
            Console.WriteLine("it works");
            ShipperExporter = "fdsf";
        }

        public void ExportToPdf()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            PdfDocument outputDocument = new PdfDocument();
            PdfDocument inputDocument = PdfReader.Open($"{path}/HBL2.pdf", PdfDocumentOpenMode.Modify);

            PdfPage page = inputDocument.Pages[0];
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 8);
            XTextFormatter textFormatter = new XTextFormatter(gfx);


            //Shipper Exporter
            if (ShipperExporter != null)
            {
                PlacePDF(20, 81, 290, 58, ShipperExporter, gfx, textFormatter, font);
            }

            //Booking Number
            if(BookingNumber != null)
            {
                PlacePDF(320, 81, 78, 10, BookingNumber, gfx, textFormatter, font);
            }

            //Bill of Landing
            if(BillOfLanding != null)
            {
                PlacePDF(400, 81, 195, 10, BillOfLanding, gfx, textFormatter, font);
            }

            //Export Reference
            if (ExportRef != null)
            {
                PlacePDF(320, 100, 275, 40, ExportRef, gfx, textFormatter, font);
            }

            //Cosignee
            if (Cosignee != null)
            {
                PlacePDF(20, 150, 290, 58, Cosignee, gfx, textFormatter, font);
            }

            //Forwarding 
            if (ForwardingAgent!= null)
            {
                PlacePDF(320, 150, 275, 40, ForwardingAgent, gfx, textFormatter, font);
            }

            //Point and Country
            if(PointAndCountry != null)
            {
                PlacePDF(320, 200, 275, 10, PointAndCountry, gfx, textFormatter, font);
            }

            //Notify
            if (Notify != null)
            {
                PlacePDF(20, 225, 290, 58, Notify, gfx, textFormatter, font);
            }

            //Point and Country
            if (AlsoNotify != null)
            {
                PlacePDF(320, 225, 275, 58, AlsoNotify, gfx, textFormatter, font);
            }

            //Initial Carriage
            if (InitialCarriage != null)
            {
                PlacePDF(20, 296, 150, 10, InitialCarriage, gfx, textFormatter, font);
            }

            //Loading Vessel
            if (LoadingVessel != null)
            {
                PlacePDF(20, 319, 150, 10, LoadingVessel, gfx, textFormatter, font);
            }

            //Port of Discharge
            if (PortOfDischarge != null)
            {
                PlacePDF(20, 340, 150, 10, PortOfDischarge, gfx, textFormatter, font);
            }

            //Place of Receipt
            if (placeOfReceipt != null)
            {
                PlacePDF(172, 296, 145, 10, PlaceOfReceipt, gfx, textFormatter, font);
            }

            //Port of Loading
            if (PortOfLoading != null)
            {
                PlacePDF(172, 319, 145, 10, PortOfLoading, gfx, textFormatter, font);
            }

            //Place of Delivery
            if (PlaceOfDelivery != null)
            {
                PlacePDF(172, 340, 145, 10, PlaceOfDelivery, gfx, textFormatter, font);
            }


            //Further Routing
            if (FurtherRouting != null)
            {
                PlacePDF(320, 296, 275, 58, FurtherRouting, gfx, textFormatter, font);
            }

            //particulars table ------------------------------------------------------------------------------------
            //Mks
            if (Mks != null)
            {
                PlacePDF(16, 387, 100, 150, Mks, gfx, textFormatter, font);
            }

            //Pks
            if (Pks != null)
            {
                PlacePDF(121, 387, 45, 150, Pks, gfx, textFormatter, font);
            }

            //Description
            if (Description != null)
            {
                PlacePDF(170, 387, 270, 150, Description, gfx, textFormatter, font);
            }

            //GrossWeight
            if (GrossWeight != null)
            {
                PlacePDF(448, 387, 73, 150, GrossWeight, gfx, textFormatter, font);
            }

            //Mesurment
            if (Mesurement != null)
            {
                PlacePDF(528, 387, 58, 150, Mesurement, gfx, textFormatter, font);
            }

            //Payment table -------------------------------------------------------------------------------------------------------------------


            inputDocument.Save($"{path}/new.pdf");
            Process.Start($"{path}/new.pdf");
        }

        private void PlacePDF(double x, double y, double width, double height, string variable, XGraphics gfx, XTextFormatter textFormatter, XFont font)
        {
            XRect rect = new XRect(x, y, width, height);
            gfx.DrawRectangle(XBrushes.SeaShell, rect);
            textFormatter.Alignment = XParagraphAlignment.Left;
            textFormatter.DrawString(variable, font, XBrushes.Black, rect, XStringFormats.TopLeft);
        }


    }
}
