using NHibernate;
using NHibernate.Cfg;


namespace CRUDNHibernate.Infrastructure
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        public NHibernateHelper()
        {
            var configuration = new Configuration();
            configuration.Configure("hibernate.cfg.xml");
            _sessionFactory = configuration.BuildSessionFactory();
        }
       // private ISessionFactory GetSessionFactory()
      //  {
      //      var sessionFactory = new Configuration().Configure().BuildSessionFactory();
      //      return sessionFactory;
       // }

        public NHibernate.ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
