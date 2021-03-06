//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace Weblitz.Mvc.Forum.Db
{
    public partial class ForumEntities : ObjectContext
    {
        public const string ConnectionString = "name=ForumEntities";
        public const string ContainerName = "ForumEntities";
    
        #region Constructors
    
        public ForumEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = false;
        }
    
        public ForumEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = false;
        }
    
        public ForumEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = false;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public IObjectSet<Forum> Forums
        {
            get { return _forums  ?? (_forums = CreateObjectSet<Forum>("Forums")); }
        }
        private IObjectSet<Forum> _forums;
    
        public IObjectSet<Post> Posts
        {
            get { return _posts  ?? (_posts = CreateObjectSet<Post>("Posts")); }
        }
        private IObjectSet<Post> _posts;
    
        public IObjectSet<Topic> Topics
        {
            get { return _topics  ?? (_topics = CreateObjectSet<Topic>("Topics")); }
        }
        private IObjectSet<Topic> _topics;

        #endregion
    }
}
