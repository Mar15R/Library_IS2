using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_IS2;
using Library_IS2.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_IS2.Services
{
    public class Security
    {
        Repository repo = new Repository(new Library2Entities());
        //public Result<User> AuthenticateUser(string username, string password)
        //{
        //    try
        //    {
        //        User user = repo.GetEntityByFilter<User>(p => p.UserName == username);
        //        if (user == null)
        //        {
        //            return new Result<User>
        //            {
        //                Data = null,
        //                ErrorMessage = "User doesn't exist."
        //            };
        //        }
        //        bool isSuccess = PasswordIsValid(user, password);

        //        if (!isSuccess)
        //        {
        //            return new Result<User>
        //            {
        //                Data = null,
        //                ErrorMessage = "Invalid password."
        //            };
        //        }
        //        return new Result<User>
        //        {
        //            Data = user
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Result<User>
        //        {
        //            Data = null,
        //            ErrorMessage = "An error occurred during authentication.",
        //            InnerExceptionMessage = ex.Message
        //        };
        //    }
        //}
        //private bool PasswordIsValid(User user, string password)
        //{
        //    bool isSuccess = user.Password == password;
        //    return isSuccess;
        //}

        public Result<User> AuthenticateUser(string username, string password)
        {
            try
            {
                User user = repo.GetEntityByFilter<User>(p => p.UserName == username);

                if (user == null)
                {
                    return new Result<User>
                    {
                        ErrorMessage = "User doesn't exist."
                    };
                }

                if (!PasswordIsValid(user, password))
                {
                    return new Result<User>
                    {
                        ErrorMessage = "Invalid password."
                    };
                }

                return new Result<User>
                {
                    Data = user
                };
            }
            catch (Exception ex)
            {
                return new Result<User>
                {
                    ErrorMessage = "An error occurred during authentication.",
                    InnerExceptionMessage = ex.Message
                };
            }
        }

        private bool PasswordIsValid(User user, string password)
        {
            return string.Equals(user.Password?.Trim(), password.Trim(), StringComparison.Ordinal);
        }

    }
}
