﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TM_SaaS_OA_EFModel;
using SMT.SaaS.Permission.DAL.views;

namespace SMT.SaaS.Permission.DAL.views
{
    public class V_UserLoginRecordHistory
    {
        public T_SYS_USER sysuser;
        public T_SYS_USERLOGINRECORDHIS historyrecord;
    }
}