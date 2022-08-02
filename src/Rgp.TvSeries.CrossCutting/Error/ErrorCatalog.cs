namespace Rgp.TvSeries.CrossCutting.Error
{
    public static class ErrorCatalog
    {
        public static class Value
        {

            #region Base

            public static ErrorCatalogEntry BaseInvalidRequest =>
                ("TEMPLATE-STANDAR-01", "Invalid request");

            #endregion Base

            #region Server

            public static ErrorCatalogEntry DatabaseError =>
                ("TEMPLATE-SERVER-01", "Something went wrong with Database Connection. Try again later.");

            #endregion Server

            #region Get

            public static ErrorCatalogEntry GetCodeIsNullOrEmpty =>
                ("TEMPLATE-GET-01", "[code] parameter cant be null or empty");

            public static ErrorCatalogEntry ListIsEmpty =>
                ("TEMPLATE-GET-02", "No registers was found");

            #endregion Get

            #region GetById

            public static ErrorCatalogEntry GetByIdNotFound =>
                ("TEMPLATE-GETBYID-01", "[id] not found");

            #endregion Get

            #region Craete

            public static ErrorCatalogEntry CraeteCodeIsNullOrEmpty =>
                ("TEMPLATE-CREATE-01", "[code] parameter cant be null or empty");

            public static ErrorCatalogEntry CraeteDescriptionIsNullOrEmpty =>
                ("TEMPLATE-CREATE-02", "[description] parameter cant be null or empty");

            public static ErrorCatalogEntry CodeCanBeNegativeNumber =>
                ("TEMPLATE-CREATE-03", "[code] parameter cant be -1");

            public static ErrorCatalogEntry DescriptionMinLenght =>
                ("TEMPLATE-CREATE-04", "[description] parameter cant be null or empty");

            #endregion Create
        }
    }

}
