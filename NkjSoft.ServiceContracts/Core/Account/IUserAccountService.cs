﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using NkjSoft.Core.Models.Account;

namespace NkjSoft.ServiceContracts.Core.Account
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IUserAccountService
    {
        ///// <summary>
        ///// Gets the roles.
        ///// </summary>
        ///// <param name="userName">Name of the user.</param>
        ///// <returns></returns>
        //[OperationContract]
        //string[] GetRoles(string userName);

        /// <summary>
        /// Gets all action permission.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Users> GetAllActionPermission();

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //[OperationContract]
        //List<Model.Common.Menu> GetAllMenus();

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //[OperationContract]
        //List<Model.Common.Menu> GetAllButtons();
    }
}
