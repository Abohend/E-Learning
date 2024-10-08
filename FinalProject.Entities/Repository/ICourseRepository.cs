using Learn.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Entities.Repository
{
    public interface ICourseRepository:IGenericRepository<Course>
    {
        void Update(Course course); 
    }
}
