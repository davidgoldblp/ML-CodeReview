using InterviewProject.Model.Entity;

namespace InterviewProject.Validation
{
    public class Validator
    {
        public List<string> GetValidationErrorsForMemberStatus(Member member, Guid memberID)
        {
            List<string> validationErrors = new List<string>();

            if (member == null) { validationErrors.Add($"member {memberID} could not be found"); }
            if (member.Status == "Active - Regular") { validationErrors.Add($"member {memberID} is not in a status that can be automatically adjusted"); }
            if (!member.ProgramEnrollments.Any()) { validationErrors.Add($"member {memberID} is not enrolled in any program"); }
            if (!member.MemberMeetingChanges.Any()) { validationErrors.Add($"member {memberID} has never had a meeting"); }

            if (member.ProgramEnrollments.Any(x =>
                x.ProgramEnrollmentTracks.Where(y => y.TrackID.ToString() == "AE96516D-F9BF-4F20-9828-45CB943D1216").Any()))
            { validationErrors.Add($"member {memberID} is in the individual track and can not be updated"); }

            return validationErrors;
        }
    }
}
