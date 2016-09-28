﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class RecipientInfo
    {
        /// <summary>
        ///  Information about the members of the recipient set
        /// </summary>
        public List<RecipientMemberInfo> recipientSetMemberInfos { get; set; }
        /// <summary>
        /// ['SIGNER' or 'APPROVER' or 'DELEGATE_TO_SIGNER' or 'DELEGATE_TO_APPROVER']: Specify the role of recipient set
        /// </summary>
        public string recipientSetRole { get; set; }
    }
}