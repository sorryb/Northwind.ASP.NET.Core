﻿namespace NorthwindWeb.Core.Models.ServerClientCommunication
{
    /// <summary>
    /// Contain data of shipper that datatable need to draw a table.
    /// </summary>
    public class ShipperData
    {
        /// <summary>
        /// The ID of shipper.
        /// </summary>
        public int ID {get; set;}

        /// <summary>
        /// The name of shipper.
        /// </summary>
        public string CompanyName  {get; set;}

        /// <summary>
        /// The phone of shipper.
        /// </summary>
        public string Phone { get; set; }
    }
}