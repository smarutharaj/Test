﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Coinco.SMS.AXWrapper
{
    public interface IAXHelper
    {
        DataTable GetDefaultSitesByUsername(string username);
        DataTable GetServiceOrders(string inventSiteId, string orderStatus, string userName);
        DataTable GetServiceOrderLinesByServiceOrderId(string serviceOrderId, string userName);
        DataTable GetSerialNumberList(string serialId, string itemNumber, string custAccount, string userName);
        DataTable GetCustomerAddressList(string customerAccount, string userName);
        DataTable GetCustomers(string userName);
        DataTable GetSalesHistory(string salesSerialNumber, string userName);
        DataTable GetSalesInformation(string salesSerialNumber, string userName);

    }
}
