using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateChekIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateChekIn = (DateTime?)row["dateCheckin"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "")
                this.discount = (int)row["discount"];
        }

        private int discount;
        public int Discount
        {
            get { return discount; }
            set { this.discount = value; }
        }

        private int status;
        public int Status
        {
            get { return Status; }
            set { status = value; }
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }

        }

        private DateTime? dateCheckIn;
        public DateTime? DateChekIn

        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }

        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
