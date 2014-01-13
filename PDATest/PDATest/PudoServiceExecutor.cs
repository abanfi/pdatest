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

        internal static void findParcelForDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
        }

        internal static void postCancelDelivery(DeliveryData deliveryData)
        {
            throw new NotImplementedException();
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

        internal static void findParcelByBarCode(PackageData packageData)
        {
            FindParcelByBarcodeRequest request = (FindParcelByBarcodeRequest) initDefaultParameters(
                new FindParcelByBarcodeRequest(), packageData);
            request.Barcode = packageData.packageCode;
            FindParcelByBarcodeResponse response = pudoClient.FindParcelByBarcode(request);
        }

        internal static void findParcelByFilter(PackageData packageData)
        {
            throw new NotImplementedException();
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
