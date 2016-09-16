using System;
using System.Data;
using WmsCore.Dao.Access;
using WmsCore.Dao.Common.Constants;
using WmsCore.Dao.DAO;
using WmsCore.Dao.Helper;

namespace WmsCore.Dao.Action
{
    [Serializable]
    public class GetItemAction
    {
        //Inherits ActionObjectInterface

        public ItemDao Dao = new ItemDao();

        public GetItemAction()
        {
        }

        #region "ActionObjectInterface Members"

        public object CreateItem(object obj)
        {
            try
            {
                return Dao.CreateItem(obj);
            }
            catch (SqlDatabaseException ex)
            {
                ExceptionHelper.ExceptionHandler(ex, ErrorType.ADD);
            }

            return null;
        }

        public object GetItemInformation(object obj)
        {
            try
            {
                return Dao.GetItemInformation(obj);
            }
            catch (SqlDatabaseException ex)
            {
                ExceptionHelper.ExceptionHandler(ex, ErrorType.SEARCH);
            }

            return null;
        }

        //public DataSet GetSellerDetails(object obj)
        //{
        //    try
        //    {
        //        return Dao.GetSellerDetails(obj);
        //    }
        //    catch (SqlDatabaseException ex)
        //    {
        //        ExceptionHelper.ExceptionHandler(ex, ErrorType.SEARCH);
        //    }

        //    return null;
        //}

        public object GetItemType(object objInput)
        {
            try
            {
                return Dao.GetItemType(objInput);
            }
            catch (System.Exception ex)
            {
                ExceptionHelper.ExceptionHandler(ex, ErrorType.ACTION);
            }

            return null;
        }

        public object GetItemID(object objInput)
        {
            try
            {
                return Dao.GetItemID(objInput);
            }
            catch (System.Exception ex)
            {
                ExceptionHelper.ExceptionHandler(ex, ErrorType.ACTION);
            }

            return null;
        }

        public object UpdateItemDetails(object obj)
        {
            try
            {
                return Dao.UpdateItemDetails(obj);
            }
            catch (SqlDatabaseException ex)
            {
                ExceptionHelper.ExceptionHandler(ex, ErrorType.SEARCH);
            }

            return null;
        }

        #endregion "ActionObjectInterface Members"
    }
}