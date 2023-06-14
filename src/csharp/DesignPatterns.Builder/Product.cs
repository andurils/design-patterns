using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    // 只有当产品较为复杂且需要详细配置时，使用生成器模式才有意义。 
    // 
    // 与其他创建型模式不同，不同的具体建造者可以生产不相关的产品。
    // 换句话说，各个建造者的结果可能并不总是遵循相同的接口。
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            str = (string)_parts.Aggregate((c, n) => c + ", " + n);

            return "Product parts: " + str + "\n";
        }
    }
}
