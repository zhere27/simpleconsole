using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WmsCore.Dao.Common.Constants;
using WmsCore.Dao.Exception;

namespace WmsCore.Dao.Helper
{
    public class ExceptionHelper
    {
        public ExceptionHelper()
        {
        }

        public static void ExceptionHandler(System.Exception e, Int16 ErrType)
        {
            if (e is System.Data.OleDb.OleDbException)
            {
                if (Strings.InStr(e.Message, "violation of primary", CompareMethod.Text) > 0)
                {
                    throw new DuplicateKeyException(MessageAlert.DUPLICATE_ERROR);
                }
                else
                {
                    switch (ErrType)
                    {
                        case ErrorType.ADD:
                            throw new MySQLDBException(MessageAlert.ADD_GENERAL_ERROR);
                        case ErrorType.EDIT:
                            throw new MySQLDBException(MessageAlert.EDIT_GENERAL_ERROR);
                        case ErrorType.DELETE:
                            throw new MySQLDBException(MessageAlert.DELETE_GENERAL_ERROR);
                        case ErrorType.SEARCH:

                            throw new MySQLDBException(MessageAlert.SEARCH_GENERAL_ERROR);
                    }
                }
            }
            else if (e is MySql.Data.MySqlClient.MySqlException)
            {
                if (Strings.InStr(e.Message, "violation of primary", CompareMethod.Text) > 0)
                {
                    throw new DuplicateKeyException(MessageAlert.DUPLICATE_ERROR);
                }
                else
                {
                    switch (ErrType)
                    {
                        case ErrorType.ADD:
                            throw new MySQLDBException(MessageAlert.ADD_GENERAL_ERROR);
                        case ErrorType.EDIT:
                            throw new MySQLDBException(MessageAlert.EDIT_GENERAL_ERROR);
                        case ErrorType.DELETE:
                            throw new MySQLDBException(MessageAlert.DELETE_GENERAL_ERROR);
                        case ErrorType.SEARCH:
                            throw new MySQLDBException(MessageAlert.SEARCH_GENERAL_ERROR);
                        case ErrorType.ACTION:
                            throw new MySQLDBException(MessageAlert.ACTION_GENERAL_ERROR);
                    }
                }
            }
            else if (e is System.Exception)
            {
                switch (ErrType)
                {
                    case ErrorType.ADD:
                        throw new AddException(MessageAlert.ADD_GENERAL_ERROR);
                    case ErrorType.EDIT:
                        throw new EditException(MessageAlert.EDIT_GENERAL_ERROR);
                    case ErrorType.DELETE:
                        throw new DeleteException(MessageAlert.DELETE_GENERAL_ERROR);
                    case ErrorType.SEARCH:
                        throw new SearchException(MessageAlert.SEARCH_GENERAL_ERROR);
                    case ErrorType.ACTION:
                        throw new ActionExceptions(MessageAlert.ACTION_GENERAL_ERROR);
                    case ErrorType.WEBPAGE:
                        throw new PageException(MessageAlert.PAGE_GENERAL_ERROR);
                    case ErrorType.PARSING:

                        throw new PageException(MessageAlert.PARSING_GENERAL_ERROR);
                }
            }
        }
    }
}