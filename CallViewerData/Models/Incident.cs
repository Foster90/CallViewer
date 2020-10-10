using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.Linq.Expressions;
using CallViewerData.Extensions;

namespace CallViewerData.Models
{
  
    

    [Table("Incident", Schema = "Fact")]
    public class Incident
    {
        [Column ("Incident Key") ]
        public Guid IncidentKey { get; set; }

        [Column("Incident ID")]
        public int IncidentID { get; set; }
                      
        [Column ("Status Key")]
        public Guid? StatusKey { get; set; }

        [Column ("Type Key")]
        public Guid? TypeKey { get; set; }


        [Column ("Life Cycle Key")]
        public Guid? LifeCycleKey { get; set; }

        [Column ("Creation User Key")]
        public Guid? CreationUserKey { get; set; }

        [Column ("Create Group Key")]

        public Guid? CreateGroupKey { get; set; }

        [Column ("Last Updated User Key")]

        public Guid? LastUpdatedUserKey { get; set; }

        [Column ("Update Group Key")]

        public Guid? UpdateGroupKey { get; set; }

        [Column ("Raise User Key")]

        public Guid? RaiseUserKey { get; set; }


        [Column ("Creation Date Key")]

        public DateTime CreationDateKey { get; set; }

        [Column ("Last Update Date Key")]

        public DateTime? LastUpdateDateKey { get; set; }

        [Column ("Priority Key")]

        public string PriorityKey { get; set; }

        [Column ("Title")]

        public string Title { get; set; }


        [Column ("Description")]       
        public string Description { get; set; }

        [NotMapped]
        public string DescShortened { get {
                if (Description != null)
                {
                    return Description.ToString().SubStringTo(30);
                }

                else return " ";
            } }

        [Column ("Reference")]
        public string Reference { get; set; }

        [Column ("Category 1 Key")]
        public Guid? Category1Key { get; set; }

        [Column ("Category 2 Key")]
        public Guid? Category2Key { get; set; }

        [Column ("Category 3 Key")]
        public Guid? Category3Key { get; set; }

        [Column ("Customer Key")]
        public Guid? CustomerKey { get; set; }

        [Column ("Organisation Key")]
        public Guid? OrganisationKey { get; set; }

        [Column ("Service Key")]
        public Guid? ServiceKey { get; set; }

        [Column ("Environment Key")]
        public Guid? EnvironmentKey { get; set; }

        [Column ("Customer Reference")]
        public string CustomerReference { get; set; }

        [Column ("Project Reference")]
        public string ProjectReference { get; set; }

        [Column ("Unassigned")]
        public byte Unassigned { get; set; }


        [Column ("Latest Assignment User Key")]
        public Guid? LatestAssignmentUserKey { get; set; }


        [Column ("Latest Assignment Key")]
        public Guid? LatestAssignmentKey { get; set; }

        [Column ("Latest Assignment Group Key")]
        public Guid? LatestAssignmentGroupKey { get; set; }

        [Column("Breach")]
        public byte Breach { get; set; }

        [Column("Breach Date Key")]
        public DateTime? BreachDateKey { get; set; }

        [Column ("Response Level Key")]
        public Guid? ResponseLevelKey { get; set; }

        [Column ("Close On Creation")]
        public int CloseOnCreation { get; set; }

        [Column ("Source Key")]
        public Guid? SourceKey { get; set; }

        [Column ("Config Item Key")]
        public Guid? ConfigItemKey { get; set; }

        [Column ("Clock Stopped")]
        public byte ClockStopped { get; set; }

        [Column ("Previous Stopped Time")]
        public int? PreviousStoppedTime { get; set; }

        [Column ("Assignment Count")]
        public byte AssignmentCount { get; set; }

        [Column ("Auto Close")]
        public byte AutoClose { get; set; }

        [Column ("Responsed")]
        public Int16 Responsed { get; set; }

        [Column ("Resolve on Creation")]
        public byte ResolveonCreation { get; set; }

        [Column ("Major Incident")]
        public byte MajorIncident { get; set; }

        [Column ("Reopened")]
        public byte Reopened { get; set; }

        [Column ("Unresolved")]
        public byte Unresolved { get; set; }

        [Column ("Incident Cause Key")]
        public Guid? IncidentCauseKey { get; set; }

        [Column ("Clinical Safety")]
        public Int16 ClinicalSafety { get; set; }

        [Column ("Converted to Request")]
        public Int16 ConvertedtoRequest { get; set; }

        [Column ("PID Removal Request")]
        public Int16 PIDRemovalReques { get; set; }

        [Column ("PID Removal Complete")]
        public Int16 PIDRemovalComplete { get; set; }

        [Column ("Impact")]
        public string Impact{ get; set; }

        [Column ("Urgency")]
        public string Urgency { get; set; }


        [Column ("Lineage Key")]
        public int LineageKey { get; set; }



    }
}
