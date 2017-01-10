using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASE
{
    public class DataModel
    {

        public class Product
        {

            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            /// <value>
            /// The identifier.
            /// </value>
            public int id { get; set; }
            /// <summary>
            /// Gets or sets the cost.
            /// </summary>
            /// <value>
            /// The cost.
            /// </value>
            public int cost { get; set; }
            /// <summary>
            /// Gets or sets the revenus.
            /// </summary>
            /// <value>
            /// The revenus.
            /// </value>
            public int revenus { get; set; }
            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public int price { get; set; }
            public Product(int id, int cost, int revenus, int price)
            {
                this.id = id;
                this.cost = cost;
                this.revenus = revenus;
                this.price = price;
            }
        }

    }
}
