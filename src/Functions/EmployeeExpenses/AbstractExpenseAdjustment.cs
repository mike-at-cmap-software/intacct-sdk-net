﻿/*
 * Copyright 2017 Intacct Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * or in the "LICENSE" file accompanying this file. This file is distributed on 
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
 * express or implied. See the License for the specific language governing 
 * permissions and limitations under the License.
 */
 
using System;
using System.Collections.Generic;

namespace Intacct.Sdk.Functions.EmployeeExpenses
{

    abstract public class AbstractExpenseAdjustment : AbstractFunction
    {

        public int? RecordNo;

        public DateTime TransactionDate;

        public string EmployeeId;

        public string ExpenseReportNumber;

        public string ExpenseAdjustmentNumber;

        public DateTime? GlPostingDate;

        public int? SummaryRecordNo;

        public string ExternalId;

        public string Action;

        public string BaseCurrency;

        public string ReimbursementCurrency;

        public string AttachmentsId;

        public string ReasonForExpense;

        public string Description;

        public string Memo;
        
        public List<AbstractExpenseAdjustmentLine> Lines = new List<AbstractExpenseAdjustmentLine>();

        //TODO: Current schema does not allow custom fields
        //public Dictionary<string, dynamic> CustomFields = new Dictionary<string, dynamic>();

        public AbstractExpenseAdjustment(string controlId = null) : base(controlId)
        {
        }
        
    }
}