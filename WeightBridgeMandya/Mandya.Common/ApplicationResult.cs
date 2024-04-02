﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.Common
{
    public class ApplicationResult
    {
        public CommonStatusType Status;
        public string ErrorException;
        public DataTable ResultDt;
        public DataSet ResultDs;
        public object ResultObj;
        public int ResultInt = 0;


        public enum CommonStatusType
        {
            Failure = 0,
            Success = 1,
            Record = 2,
            RecordExists = 3,
            RecordNotexists = 4,
            RecordFkViolation = 5
        }


        public ApplicationResult()
        {
            Status = CommonStatusType.Success;
            ErrorException = null;
            ResultDt = null;
            ResultDs = null;
            ResultObj = null;
            ResultInt = 0;
        }


        public ApplicationResult(DataTable dt)
        {
            Status = CommonStatusType.Success;
            ErrorException = null;
            ResultDt = dt;
            ResultObj = null;
            ResultInt = 0;
        }

        public ApplicationResult(DataSet ds)
        {
            Status = CommonStatusType.Success;
            ErrorException = null;
            //resultDT = dt;
            ResultDs = ds;
            ResultObj = null;
            ResultInt = 0;
        }


        public ApplicationResult(string errMsg)
        {
            Status = CommonStatusType.Failure;
            ErrorException = errMsg;
            ResultDt = null;
            ResultDs = null;
            ResultObj = null;
            ResultInt = 0;

        }

        public ApplicationResult(int integerresult)
        {
            Status = CommonStatusType.Success;
            ErrorException = null;
            ResultDt = null;
            ResultDs = null;
            ResultObj = null;
            ResultInt = integerresult;
        }

        public ApplicationResult(object objResult)
        {
            Status = CommonStatusType.Success;
            ErrorException = null;
            ResultDt = null;
            ResultDs = null;
            ResultObj = objResult;
            ResultInt = 0;
        }
    }
}
