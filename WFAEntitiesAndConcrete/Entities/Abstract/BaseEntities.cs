using System;

namespace WFAEntitiesAndConcrete.Entities.Abstract
{
    public abstract class BaseEntities
    {
        public int Id { get; set; }
        
        private DateTime _createTime = DateTime.Now;

        public DateTime CreateTime => _createTime;
    }
}