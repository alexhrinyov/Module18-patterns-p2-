using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Строитель для создания рассылки о заказе
    /// </summary>
    internal class OrderTemplateBuilder: TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте, спасибо за заказ!" };
        }

        public override void BuildBody()
        {
            this.Template.Body = new Body { Text = "Ваш номер заказа - 534" };
        }

        public override void BuildFooter()
        {
            this.Template.Footer = new Footer() { Text = "OOO ЛучшийСервис, contact@bestservice.ru" };
        }
    }
}
