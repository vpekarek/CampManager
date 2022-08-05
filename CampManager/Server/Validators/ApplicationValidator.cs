using FluentValidation;

namespace CampManager.Server.Validators;
public class ApplicationValidator : AbstractValidator<Model.Application>
{
    public ApplicationValidator()
    {
        RuleFor(application => application.CampId)
            .NotNull()
            .NotEqual(Guid.Empty)
            .WithMessage("Please ensure you have selected camp.");
        RuleFor(application => application.Participants)
            .NotNull()
            .NotEmpty()
            .WithMessage("Please ensure you have added at least one participant.");
        RuleFor(application => application.Representatives)
            .NotNull()
            .NotEmpty()
            .WithMessage("Please ensure you have added at least one representative.");
        RuleForEach(application => application.Participants)
            .SetValidator(new ApplicationParticipantValidator());
    }
}
