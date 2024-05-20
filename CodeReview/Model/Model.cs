using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProject.Model.Entity
{
    public class Model() { }

    public class Member
    {
        public Guid? MemberID { get; set; }
        public string Gender { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string MRN { get; set; }
        public string DisplayName { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string Status { get; internal set; }

        public List<ProgramEnrollment> ProgramEnrollments { get; internal set; }
        public List<MemberMeetingChange> MemberMeetingChanges { get; internal set; }
    }

    public class MemberMeetingChange
    {
        public Guid MemberMeetingChangeID { get; set; }
        public Guid MemberID { get; set; }
        public Member Member { get; set; } // Navigation property
        string DisplayName { get; set; }

        public DateTime ChangeDate {get;set;}
    }

    public class ProgramEnrollment
    {
        public Guid ProgramEnrollmentID { get; set; }
        public Guid MemberID { get; set; }
        public Member Member { get; set; } // Navigation property
        public List<ProgramEnrollmentTrack> ProgramEnrollmentTracks { get;set;}
        public Guid ProgramID { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }

    }
    public class ProgramEnrollmentTrack
    {
        public Guid ProgramEnrollmentTrackID { get; set;}
        public Track Track { get; set; }
        public Guid TrackID;

    }

    public class Track
    {
        public Guid TrackID { get; set; }
        public string Name { get; set; }
    }
}
