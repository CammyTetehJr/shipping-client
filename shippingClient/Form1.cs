using shippingClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shippingClient
{
    public partial class Form1 : Form, IShippingCallback
    {
        ShippingClient  proxy;
        InstanceContext context;
        IShippingCallback callback;
        List<Order> orders;
        
        public Form1()
        {
            InitializeComponent();
            callback = this;
            context = new InstanceContext(callback);
            proxy = new ShippingClient(context);
            proxy.SubscribeEvent();
            orders = new List<Order>();
        }


        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            orders = proxy.GetOrderList().ToList();
            foreach ( Order o in orders)
            {
                lbOrderedProduct.Items.Add(o.ProductId);
                lbTimeOrdered.Items.Add(o.Moment);
            }
        }

        public void OnProductBought(Order o)
        {
            orders.Add(o);
            lbOrderedProduct.Items.Add(o.ProductId);
            lbTimeOrdered.Items.Add(o.Moment);
            
        }

        private void RefreshList()
        {
            lbOrderedProduct.Items.Clear();
            lbTimeOrdered.Items.Clear();
        }
    }
}
