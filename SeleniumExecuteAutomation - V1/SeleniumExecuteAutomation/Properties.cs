using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExecuteAutomation
{
    //Important for enum to be outside of class so it is visible throughout whole solution
    enum PropertyType
    {
        Id,
        Name,
        CssName,
        LinkText,
        ClassName
    }

    class Properties
    {
        public static  IWebDriver driver{ get; set; }
    }
}
