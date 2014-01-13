using PDATestProject.Datas;
using PDATestProject.PDAPudoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public static class PudoServiceExecutor
    {
        private static PdaPudoServiceClient pudoClient = new PdaPudoServiceClient();

        private static BaseRequest initDefaultParameters(BaseRequest request, DefaultData data){
            request.LanguageCode = (LanguageCodeType) Enum.Parse(typeof(LanguageCodeType), data.languageCode);
            request.OfflineMode = data.offline.Equals("Igen");
            request.TerminalID = data.terminalId;
            request.TransactionID = Convert.ToInt64(data.transactionId);
            return request;
        }

        private static DefaultReturnData createSummaryMessage(DefaultReturnData data, BaseResponse response)
        {
            data.summaryMessage = "RESULT: " + (response.Result ? "SUCCESS " : "FAILED ") + " - ERROR CODE: " + 
                response.ErrorCode + " - ERROR MESSAGE: " + response.ErrorMessage ; 

            return data;
        }

        internal static void findParcelForDelivery(DeliveryData deliveryData)
        {
            FindParcelForDeliveryRequest request = (FindParcelForDeliveryRequest)initDefaultParameters(
                new FindParcelForDeliveryRequest(), deliveryData);
            request.Barcode = deliveryData.packageCode;

            FindParcelForDeliveryResponse response = pudoClient.FindParcelForDelivery(request);
            
        }

        internal static void postCancelDelivery(DeliveryData deliveryData)
        {
            PostCancelDeliveryRequest request = (PostCancelDeliveryRequest)initDefaultParameters(
                new PostCancelDeliveryRequest(), deliveryData);
            //TODO kitölteni a megfelelő értékekkel 
            //request.DeliveryParcels = deliveryData.packageCode;

            PostCancelDeliveryResponse response = pudoClient.PostCancelDelivery(request);
        }

        internal static void postRefuseDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
        }

        internal static void postDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
        }

        internal static void getHoliday(HolidayData holidayData)
        {
            throw new NotImplementedException();
        }

        internal static void setHoliday(HolidayData holidayData)
        {
            throw new NotImplementedException();
        }

        internal static void findInsertedDictionarySince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findInsertedPartnerSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findInsertedParcelSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedDictionarySince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedPartnerSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void findDeletedParcelSince(MasterDataData masterDataData)
        {
            throw new NotImplementedException();
        }

        internal static void getOpeningHours(OpeningHoursData openingHoursData)
        {
            throw new NotImplementedException();
        }

        internal static void setOpeningHours(OpeningHoursData openingHoursData)
        {
            throw new NotImplementedException();
        }

        internal static PackageReturnData findParcelByBarCode(PackageData packageData)
        {
            // init request with default parameters
            FindParcelByBarcodeRequest request = (FindParcelByBarcodeRequest) initDefaultParameters(
                new FindParcelByBarcodeRequest(), packageData);
            // add unique parameters
            request.Barcode = packageData.packageCode;

            //execute service call
            FindParcelByBarcodeResponse response = pudoClient.FindParcelByBarcode(request);

            //create return object with base properties
            PackageReturnData returnData = (PackageReturnData) createSummaryMessage( new PackageReturnData(), response);

            //initialize custom values
            return initPackageReturnParcelComposites(returnData, response.ParcelComposites);
        }

        internal static PackageReturnData findParcelByFilter(PackageData packageData)
        {
            // init request with default parameters
            FindParcelByFilterRequest request = (FindParcelByFilterRequest)initDefaultParameters(
                new FindParcelByFilterRequest(), packageData);
            
            // add unique parameters
            request.BarcodeFilter = packageData.filterPackageCode;
            request.CustomerAddressFilter = packageData.customerAddress;
            request.CustomerNameFilter = packageData.customerName;
            request.CustomerZipFilter = packageData.customerZip;

            //execute service call
            FindParcelByFilterResponse response = pudoClient.FindParcelByFilter(request);

            //create return object with base properties
            PackageReturnData returnData = (PackageReturnData) createSummaryMessage(new PackageReturnData(), response);

            //initialize custom values
            return initPackageReturnParcelComposites(returnData, response.ParcelComposites);
        }

        private static PackageReturnData initPackageReturnParcelComposites(PackageReturnData returnData, ParcelComposite[] composites)
        {
            foreach (ParcelComposite composite in composites)
            {
                ParcelCompositeReturnData data = new ParcelCompositeReturnData();
                data.BagBarcode = composite.Parcel.BagBarcode;
                data.Barcode = composite.Parcel.Barcode;
                data.Currency = composite.Parcel.Currency;
                data.CustomerAddress = composite.Parcel.CustomerAddress;
                data.CustomerName = composite.Parcel.CustomerName;
                data.CustomerPostalCode = composite.Parcel.CustomerPostalCode;
                data.Damaged = composite.Parcel.Damaged;
                data.DestinationLocationID = composite.Parcel.DestinationLocationID;
                data.LinkedCount = composite.Parcel.LinkedCount;
                data.LocationID = composite.Parcel.LocationID;
                data.LocationName = composite.Location.LocationName;
                data.NextLinkedBarcode = composite.Parcel.NextLinkedBarcode;
                data.OldBarcode = composite.Parcel.OldBarcode;
                data.ParcelState = composite.Parcel.ParcelState;
                data.ParcelWorkflow = composite.Parcel.ParcelWorkflow;
                data.PartnerID = composite.Parcel.PartnerID;
                data.PartnerName = composite.Partner.PartnerName;
                data.PriceAtDelivery = composite.Parcel.PriceAtDelivery;
                data.ReturnDate = composite.Parcel.ReturnDate;
                data.ShipmentID = composite.Parcel.ShipmentID;

                returnData.datas.Add(data);

            }
            return returnData;
        }

        internal static void findPartnerById(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void findPartnerByFilter(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void countPartnerByFilter(PartnerData partnerData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForReceive(ReceiveData receiveData)
        {
            throw new NotImplementedException();
        }

        internal static void postReceive(ReceiveData receiveData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForReturn(ReturnData returnData)
        {
            throw new NotImplementedException();
        }

        internal static void postReturn(ReturnData returnData)
        {
            throw new NotImplementedException();
        }

        internal static void findParcelForDelivery(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postRefuseCustRetPrereg(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postCustRetPrereg(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }

        internal static void postCustRetUnexpected(ReturnPreRegData returnPreRegData)
        {
            throw new NotImplementedException();
        }
    }
}
