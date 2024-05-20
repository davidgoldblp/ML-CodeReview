// See https://aka.ms/new-console-template for more information
using InterviewProject.Model;
using InterviewProject.Model.Entity;

var memberID = Guid.NewGuid();
var oudProgramID = Guid.NewGuid();

var weeklyTrackID = new Guid("AE96516D-F9BF-4F20-9828-45CB943D1216");


var member = new Member()
{
    MemberID = memberID,
    Gender = "Male",
    BirthDate = new DateOnly(1997, 2, 19),
    MRN = memberID.ToString().Substring(0,6),
    DisplayName = "Ralph Bunson",
    PrimaryPhoneNumber = "(123) 324-123",
    Status = "Active - Regular",
};

member.ProgramEnrollments = new List<ProgramEnrollment>
{
    new ProgramEnrollment()
    {
        ProgramEnrollmentID = Guid.NewGuid(),
        MemberID = memberID,
        Member = member,
        ProgramID = oudProgramID,
        ProgramName = "OUD",
        ProgramDescription = "Opoid Use Disorder",
        ProgramEnrollmentTracks = new List<ProgramEnrollmentTrack>()
        {
            new ProgramEnrollmentTrack()
            {
                ProgramEnrollmentTrackID = Guid.NewGuid(),
                Track = new Track()
                {
                    TrackID = weeklyTrackID,
                    Name = "Weekly",
                }
            }
        }
    }
};

member.MemberMeetingChanges = new List<MemberMeetingChange>() { };
