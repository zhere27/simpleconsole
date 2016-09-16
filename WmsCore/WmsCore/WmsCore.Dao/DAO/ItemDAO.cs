using System.Data;
using System.Data.SqlClient;
using WmsCore.Dao.Access;
using WmsCore.Dao.ValuesObjects;

namespace WmsCore.Dao.DAO
{
    public class ItemDao
    {
        public ItemDao()
        {
        }

        public object CreateItem(object obj)
        {
            ConnValues connStr = new ConnValues();
            SqlDatabase sqldb = new SqlDatabase(connStr.conn());
            ItemVo vo = (ItemVo)obj;

            SqlParameter[] @params = new SqlParameter[2];

            @params[0] = new SqlParameter("emailaddress", SqlDbType.VarChar);
            @params[0].Value = vo.ItemCode;

            @params[1] = new SqlParameter("result", SqlDbType.VarChar, 40);
            @params[1].Direction = ParameterDirection.Output;

            try
            {
                IDataReader dr = sqldb.ExecuteReader("CreateItemSp", CommandType.StoredProcedure, @params);

                return @params[1].Value;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public object GetItemInformation(object obj)
        {
            ConnValues connStr = new ConnValues();
            SqlDatabase sqldb = new SqlDatabase(connStr.conn());
            ItemVo vo = (ItemVo)obj;

            SqlParameter[] @params = new SqlParameter[2];

            @params[0] = new SqlParameter("emailaddress", SqlDbType.VarChar);
            @params[0].Value = vo.ItemCode;

            @params[1] = new SqlParameter("result", SqlDbType.VarChar, 40);
            @params[1].Direction = ParameterDirection.Output;

            try
            {
                IDataReader dr = sqldb.ExecuteReader("CreateItemSp", CommandType.StoredProcedure, @params);

                return @params[1].Value;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public object GetItemType(object obj)
        {
            ConnValues connStr = new ConnValues();
            SqlDatabase sqldb = new SqlDatabase(connStr.conn());
            ItemVo vo = (ItemVo)obj;

            SqlParameter[] @params = new SqlParameter[2];

            @params[0] = new SqlParameter("emailaddress", SqlDbType.VarChar);
            @params[0].Value = vo.ItemCode;

            @params[1] = new SqlParameter("result", SqlDbType.VarChar, 40);
            @params[1].Direction = ParameterDirection.Output;

            try
            {
                IDataReader dr = sqldb.ExecuteReader("CreateItemSp", CommandType.StoredProcedure, @params);

                return @params[1].Value;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public object GetItemID(object obj)
        {
            ConnValues connStr = new ConnValues();
            SqlDatabase sqldb = new SqlDatabase(connStr.conn());
            ItemVo vo = (ItemVo)obj;

            SqlParameter[] @params = new SqlParameter[2];

            @params[0] = new SqlParameter("emailaddress", SqlDbType.VarChar);
            @params[0].Value = vo.ItemCode;

            @params[1] = new SqlParameter("result", SqlDbType.VarChar, 40);
            @params[1].Direction = ParameterDirection.Output;

            try
            {
                IDataReader dr = sqldb.ExecuteReader("CreateItemSp", CommandType.StoredProcedure, @params);

                return @params[1].Value;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public object UpdateItemDetails(object obj)
        {
            ConnValues connStr = new ConnValues();
            SqlDatabase sqldb = new SqlDatabase(connStr.conn());
            ItemVo vo = (ItemVo)obj;

            SqlParameter[] @params = new SqlParameter[2];

            @params[0] = new SqlParameter("emailaddress", SqlDbType.VarChar);
            @params[0].Value = vo.ItemCode;

            @params[1] = new SqlParameter("result", SqlDbType.VarChar, 40);
            @params[1].Direction = ParameterDirection.Output;

            try
            {
                IDataReader dr = sqldb.ExecuteReader("CreateItemSp", CommandType.StoredProcedure, @params);

                return @params[1].Value;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}