using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Models
{
    public class TaskModel
    {
        public TaskModel()
        {
            Teams = new List<SelectListItem>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [DisplayName("Team")]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public IEnumerable<SelectListItem> Teams { get; set; }
    }
}