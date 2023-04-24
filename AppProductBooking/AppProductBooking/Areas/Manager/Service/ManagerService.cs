using AppProductBooking.Util;

namespace AppProductBooking.Areas.Manager.Service
{
    public class ManagerService : ApiService
    {
        #region [Properties]
        private static string urlApi = "Manager/";

        #endregion

        #region [Construtor]
        public ManagerService()
        {
        }
        #endregion

        #region [Service]
        public static bool ExistsEmail(string email)
        {
            #region [Url Api]
            urlApi += string.Format("ExistsEmail?email={0}", email);
            #endregion

            #region [Response]
            var responseApi = ApiService.GetAsync<BaseResponse<bool>>(urlApi);
            #endregion

            #region [Validation]
            if (responseApi.CodigoError == "0")
            {

            }
            #endregion

            return responseApi.Data;
        }
        #endregion
    }
}
