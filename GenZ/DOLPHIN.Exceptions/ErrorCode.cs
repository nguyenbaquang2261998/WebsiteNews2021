using System;

namespace DOLPHIN.Exceptions
{
    public enum ErrorCode
    {
        /// <summary>
        /// Forbidden
        /// </summary>
        InternalException = 500,

        /// <summary>
        /// Forbidden
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// Un-Authorized
        /// </summary>
        UnAuthorized = 401,

        /// <summary>
        /// Job Not Found
        /// </summary>
        JobNotFound = 1500,

        /// <summary>
        /// User Not Found
        /// </summary>
        UserNotFound = 1600,

        /// <summary>
        /// User Restricted
        /// </summary>
        UserRestricted = 1601,

        /// <summary>
        /// Contract Not Found
        /// </summary>
        ContractNotFound = 1700,

        /// <summary>
        /// Permission Invalid
        /// </summary>
        PermissionInvalid = 1800,

        /// <summary>
        /// Argument Invalid
        /// </summary>
        ArgumentInvalid = 2000,

        /// <summary>
        /// Argument Null
        /// </summary>
        ArgumentNull = 2001,

        /// <summary>
        /// Argument Less Than Or Equal Zero
        /// </summary>
        ArgumentLessThanZero = 2002,

        /// <summary>
        /// Argument Less Than Or Equal Zero
        /// </summary>
        ArgumentLessThanOrEqualZero = 2003,

        /// <summary>
        /// Argument Our Of Range
        /// </summary>
        ArgumentOutOfRange = 2004,

        /// <summary>
        /// Argument Null Or Empty
        /// </summary>
        ArgumentNullOrEmpty = 2005,

        /// <summary>
        /// Argument Null Or White Space
        /// </summary>
        ArgumentNullOrWhiteSpace = 2006,

        /// <summary>
        /// Post Not Found.
        /// </summary>
        PostNotFound = 2007,

        /// <summary>
        /// Category Not Found.
        /// </summary>
        CategoryNotFound = 2007,

        /// <summary>
        /// Role Name Exists.
        /// </summary>
        RoleNameExists = 2008,

        /// <summary>
        /// Role Already Has User.
        /// </summary>
        RoleAlreadyHasUser = 2009,

        /// <summary>
        /// Permission is required.
        /// </summary>
        PermissionIsRequired = 2010,

        /// <summary>
        /// Category Level Is Out Of Limit.
        /// </summary>
        CategoryLevelOutOfLimit = 2011,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        FileTypeInvalid = 2012,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        WorkspaceExists = 2013,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        WorkspaceNull = 2014,

        /// <summary>
        /// File Type Invalid
        /// </summary>
        GroupExists = 2015,

        /// <summary>
        /// File Type Invalid
        /// </summary>
        GroupNull = 2016,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        WorkspaceRoleExists = 2017,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        WorkspaceRoleNull = 2018,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        HostExist = 2019,

        /// <summary>
        /// File Type Invalid.
        /// </summary>
        HostNull = 2020,

        /// <summary>
        /// Invalid Invitation Id.
        /// </summary>
        InvalidInvitationId = 2021,

        /// <summary>
        /// GroupHostExist.
        /// </summary>
        GroupHostExists = 2022,

        /// <summary>
        /// EngineNotWork.
        /// </summary>
        EngineNotWork = 2023,

        /// <summary>
        /// GroupHostExist.
        /// </summary>
        WhiteIpExists = 2024,

        /// <summary>
        /// PleaseDeleteGroup.
        /// </summary>
        PleaseDeleteGroup = 2025,

        /// <summary>
        /// PleaseDeleteGroup.
        /// </summary>
        PleaseDeleteHost = 2026,

        /// <summary>
        /// EmailExistInvite.
        /// </summary>
        EmailExistInvite = 2027,

        /// <summary>
        /// EmailInvalid.
        /// </summary>
        EmailInvalid = 2028,

        /// <summary>
        /// RolePermissionNull.
        /// </summary>
        RolePermissionNull = 2029,

        /// <summary>
        /// WorkspaceRoleHaveMember.
        /// </summary>
        WorkspaceRoleHaveMember = 2030,

        /// <summary>
        /// ExpiredTimeNull.
        /// </summary>
        ExpiredTimeNull = 2031,

        /// <summary>
        /// ExpiredTimeInvalid.
        /// </summary>
        ExpiredTimeInvalid = 2032,

        /// <summary>
        /// HostLimitInvalid.
        /// </summary>
        HostLimitInvalid = 2032,

        /// <summary>
        /// HostExceeded.
        /// </summary>
        HostExceeded = 2035,

        /// <summary>
        /// WorksapeNotActive.
        /// </summary>
        WorksapeNotActive = 2036,

        /// <summary>
        /// ExpiredTime.
        /// </summary>
        ExpiredTime = 2037,

        /// <summary>
        /// WorkspaceNameIsTooLong.
        /// </summary>
        WorkspaceNameIsTooLong = 2038,

        /// <summary>
        /// HostLimitIsTooLarge.
        /// </summary>
        HostLimitIsTooLarge = 2039,

        /// <summary>
        /// EndDateLessCurrentTime.
        /// </summary>
        EndDateLessCurrentTime = 2040,

        /// <summary>
        /// EndDateBiggerCurrentTime.
        /// </summary>
        EndDateBiggerCurrentTime = 2041,

        /// <summary>
        /// ReCaptChaInvalid.
        /// </summary>
        ReCaptChaInvalid = 2042,

        /// <summary>
        /// WorkspaceCreatedByCurrentUser.
        /// </summary>
        WorkspaceCreatedByCurrentUser = 2043,

        /// <summary>
        /// UserHasExistedWorkspace.
        /// </summary>
        UserHasExistedWorkspace = 2044,

        /// <summary>
        /// InvitationNotOfUser.
        /// </summary>
        InvitationNotOfUser = 2045,
    }
}
