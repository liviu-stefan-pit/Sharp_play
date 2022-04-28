using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs.CreationalPatterns.FactoryMethod
{
    //usage 5/5
    #region Product
    public abstract class Page
    {
    }
    #endregion

    #region Concrete product
    public class SkillsPage : Page
    {
    }

    public class EducationPage : Page
    {
    }
    #endregion

    #region Creator
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreatePages();
    }
    #endregion

    #region Concrete creator
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
        }
    }
    #endregion
}
