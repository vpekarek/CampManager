using FluentValidation;

namespace CampManager.Server.Validators;

public class ApplicationParticipantValidator : AbstractValidator<Shared.Application.ApplicationParticipantModel>
{
    public ApplicationParticipantValidator()
    {
        RuleFor(participant => participant.IdentificationNumber)
            .NotNull()
            .NotEmpty()
            .WithMessage("Please ensure you have filled participant identification number.");
    }
}
