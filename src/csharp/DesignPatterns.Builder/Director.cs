using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    // 主管只负责按照特定顺序执行生成步骤。其在根据特定步骤或配置来生成产品时
    // 会很有帮助。由于客户端可以直接控制生成器，所以严格意义上来说，主管类并
    // 不是必需的。
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // 主管可同由客户端代码传递给自身的任何生成器实例进行交互。客户端可通
        // 过这种方式改变最新组装完毕的产品的最终类型。主管可使用同样的生成步
        // 骤创建多个产品变体。

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
