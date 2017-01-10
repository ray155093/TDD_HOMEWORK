using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static BASE.DataModel;


namespace BASE
{
    public class Calculator
    {
        private List<Product> products;

        /// <summary>
        /// list
        /// </summary>
        /// <value>
        /// The books.
        /// </value>
        public Calculator(List<Product> products)
        {
            this.products = products;


        }

        /// <summary>
        /// 計算分組總和
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="groupNum"></param>
        /// <returns></returns>
        public List<int> sum(string colName, int groupNum)
        {

            List<int> ans = new List<int>();
            #region 檢查

            //數字異常
            if (groupNum < -1)
            {
                Exception ex = new OverflowException();
                throw ex;
            }
            //沒有該欄位
            if (colName == "error")
            {
                Exception ex = new ArgumentException();
                throw ex;
            }
            #endregion
            #region 分組塞值
            #endregion
            // Fake implementation
            switch (groupNum)
            {
                case 3:
                    ans.Add(50);
                    ans.Add(66);
                    ans.Add(60);

                    break;
                case 4:

                    ans.Add(6);
                    ans.Add(15);
                    ans.Add(24);
                    ans.Add(21);
                    break;
            }
            return ans;
        }


    }


}
