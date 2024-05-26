using System.ComponentModel;

namespace LSMinimalApi.Contracts.Enums.ValidationCodes;

/// <summary>
/// Used to write validation codes. Usually called `[ClassYouWantToValidate]ValidationCodes`.
/// Usually used inside validators.
/// </summary>
public enum UsersValidationCodes
{
    [Description("User name is required")]
    UVC001,
}