using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingConsoleApp.model
{
    public abstract class Model
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        /**
         * Creation of Brand new Intance
         */
        public Model(string createdBy)
        {
            this.Id = Guid.NewGuid();
            this.CreatedBy = createdBy;
            this.CreatedAt = DateTime.Now;
            
        }
        /**
         * Updating from existing instance
         */
        public Model(Guid id, string createdBy, DateTime createdAt, string updatedBy)
        {
            this.Id = id;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = DateTime.Now;
        }
        /**
         * Creating a new instance from another instance properties`
         */
        public Model(Guid id, string createdBy, DateTime createdAt, string updatedBy, DateTime updatedAt)
        {
            this.Id = id;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = updatedAt;
        }
        /**
         * Creating a new instance from another instance
         */
        public Model(Model model)
        {
            this.Id = model.Id;
            this.CreatedBy = model.CreatedBy;
            this.CreatedAt = model.CreatedAt;
            this.UpdatedBy = model.UpdatedBy;
            this.UpdatedAt = model.UpdatedAt;
        }
    }
}
