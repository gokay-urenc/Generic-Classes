using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{         
    public class MyClass<T> /*where T:class*/ /*where T:struct*/
    {
        public int MyProperty { get; set; }
        public T DinamikProperty { get; set; }
    }
}
/* Generic(Şablon Tipler): Bir objenin tipinin tanımlama aşamasın değil oluşturulma aşamasında         belirlenmesidir. 
   Generic kullanım c# içerisinde tip güvenliğini sağlamaktadır .
   Generic class oluşturmak için <T> yazılır. T type'ın kısaltmasıdır.
   Bunun anlamı MyClass sınıfından instance alınırken tip belirleme zorunluluğunun olduğudur.
   Genericlerde kısıtlayıcı, T'nin referans veya değer tip olma zorunluluğudur.
   Kısıtlama için where ile T tipinin ne olacağına karar verilir.
*/