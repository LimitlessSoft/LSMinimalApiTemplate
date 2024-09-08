using System.ComponentModel;

namespace MyProject.Contracts.Enums.ValidationCodes;

/// <summary>
/// Used to write validation codes. Usually called `[ClassYouWantToValidate]ValidationCodes`.
/// Usually used inside validators.
/// </summary>
public enum UsersValidationCodes
{
    [Description("User name is required")]
    UVC001,
}