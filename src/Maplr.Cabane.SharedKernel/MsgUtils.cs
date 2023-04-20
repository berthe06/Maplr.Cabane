namespace Maplr.Cabane.SharedKernel;

public class MsgUtils

{
    protected MsgUtils()
    {

    }
    public static readonly string Status_Code200 = "OK";
    public static readonly string Status_Code204 = "No Content";
    public static readonly string Status_Code202 = "Accepted";

    public static readonly string Status_Code307 = "Temporary Redirect";
    public static readonly string Status_Code308 = "Permanent Redirect";
    public static readonly string Status_Code304 = "Not Modified";
    public static readonly string Status_Code302 = "Found";

    public static readonly string Status_Code400 = "Bad Request";
    public static readonly string Status_Code401 = "Unauthorized";
    public static readonly string Status_Code402 = "Payement Required";
    public static readonly string Status_Code403 = "Forbidden";
    public static readonly string Status_Code404 = "Not Found";
    public static readonly string Status_Code408 = "Request Time Out";


    public static readonly string Status_Code500 = "Internal Server Error";
    public static readonly string Status_Code511 = "Network Authentication Required";
    public static readonly string Status_Code599 = "Network Connect Timeout Error";


    public static readonly string EMPTY_FILE = "server.msg.empty_file";
    public static readonly string OK = "server.msg.ok";
    public static readonly string OK_BUT_NO_MESSAGE_SEND = "server.msg.ok_but_no_message_send";
    public static readonly string OPERATION_DELETE_DOCUMENT_FAIL = "server.msg.operation_delete_document_fail";
    public static readonly string LOGOUT_OK = "server.msg.logout.success";
    public static readonly string OPERATION_FAILED = "server.msg.process_error";
    public static readonly string PASSWD_DO_NOT_MATCH = "server.msg.passwd_do_not_match";
    public static readonly string INVALID_USER_EMAIL = "server.msg.invalid_user_email";
    public static readonly string INVALID_USER_PASSWD = "server.msg.invalid_user_passwd";
   
    public static readonly string BAD_PARAMETERS = "server.msg.bad_parameter";
    public static readonly string REQUIRED_MANDATORIES_PARAMTERS = "server.msg.required_mandatories_params";
    public static readonly string NOT_REFERENTIAL_DATA_IN = "server.msg.not_referential_data_in";
    public static readonly string BAD_PASSWORD_PARAMETERS = "server.msg.bad_password_parameter";
    public static readonly string INVALID_AMOUNT = "server.msg.invalid_amount";
    public static readonly string INVALID_USER = "server.msg.invalid_user";
    public static readonly string USER_ID_REQUIRED = "server.msg.user_id_required";
    public static readonly string USER_USER_NOT_ACTIVE = "server.msg.user_not_active";
    public static readonly string INVALID_MODEL = "server.msg.model";
    public static readonly string INVALID_SPECIALITY_CODE_LIST = "specility_code_can't_not_be_null";


    
    public static readonly string INVALID_ID = "server.msg.invalid_id";
    public static readonly string NOT_FOUND = "server.msg.not_found";
    public static readonly string EXPIRED_SESSION = "server.msg.expire_session";
    public static readonly string INVALID_SESSION = "server.msg.invalid_session";
    public static readonly string FORBIDDEN = "server.msg.forbidden";

    public static readonly string OPERATION_NOT_ALLOWED = "server.msg.operation_not_allowed";




    public static readonly string INVALID_ACCOUNT_NUMBER = "server.msg.invalid_account_number";
    public static readonly string INVALID_AlERT = "server.msg.invalid_alert_number";

    public static readonly string REJECT_REASON_REQUIRED = "server.msg.reject_reason_required";
    public static readonly string INVALID_DATA = "server.msg.invalid_data";
    public static readonly string NO_BINDING_MODEL = "server.msg.no_binding_model";
    public static readonly string NO_DATA = "server.msg.no_data_in_data_base";
    public static readonly string REQUIRED_PRIVILEGED = "server.msg.required_privileged";
    public static readonly string NO_DATA_TO_UPDATE = "server.msg.no_data_to_update";
    public static readonly string INVALID_DIPLOMA_ID = "server.msg.invalid_diploma_id";
    public static readonly string UNKNOWN_STEP = "server.msg.unknown_step";
    public static readonly string STEP_ALREADY_VALIDATED = "server.msg.step_already_validated";
    public static readonly string STEP_ALREADY_INVALIDATED = "server.msg.step_already_invalidated";

    public static readonly string INVALID_ROLE = "server.msg.invalid_role";
    public static readonly string INVALID_USER_INFORMATIONS = "server.msg.invalid_user_informations";
    public static readonly string INVALID_AUTHENTICATION_REQUEST_CODE = "server.msg.invalid_authentication_request_code";

   
   
    internal static readonly string INVALID_MODULE = "server.msg.invalid_module";
    internal static readonly string INVALID_DEPARTMENTSCHOOL = "server.msg.invalid_departmentschool";
    internal static readonly string INVALID_EVALUATION_TYPE = "server.msg.invalid_evaluation_type";



    public static readonly string INVALID_PROPERTIES = "server.msg.invalid_properties";
    public static readonly string INTERNAL_SERVER_ERROR = "server.msg.internal_server_error";


    public static readonly string BAD_ID = "server.msg.bad.id";
    public static readonly string LOGIN_FAILED = "server.msg.login_failed";
    public static readonly string REACTIVATE_USER_FAILED = "server.msg.reactivate_user_failed";
    public static readonly string DELETE_USER_FAILED = "server.msg.delete_user_failed";

    public static readonly string EMPTY_USER = "server.msg.empty_user";


    public static readonly string GET_CURRENT_USER_FAILED = "server.msg.get_current_user_failed";
    public static readonly string GET_ALL_USERS_FAILED = "server.msg.get_all_users_failed";

    public static readonly string GET_USER_FILTER_FAILED = "server.msg.get_user_filter_failed";
    /// <summary>
    /// lease exception
    /// </summary>
    public static readonly string FILE_SIZE_INVALID = "server.msg.file_size_is_invalid_sent_file_between_[1,300_KB]";







    public static readonly string EMPTY_UNITY = "server.msg.empty_unity";

    public static readonly string EMPTY_LIST = "server.msg.empty_list";

    /// <summary>
    /// HTTP STATUS CODE 
    /// USE TO MANAGE HTTP SERVICES STATUS RESPONSES
    /// </summary>
    public static readonly int HTTP_200 = 200; // OK
    public static readonly int HTTP_201 = 201; // CREATED
    public static readonly int HTTP_202 = 202; // NOT AUTHORITATIVE INFORMATIONS
    public static readonly int HTTP_204 = 204; // NO CONTENT RECORDED

    public static readonly int HTTP_400 = 400; // BADREQUEST 
    public static readonly int HTTP_401 = 401; // UNAUTHORIZED
    public static readonly int HTTP_403 = 403; // FORBIDDEN
    public static readonly int HTTP_404 = 404; // NOT_FOUND
    public static readonly int HTTP_407 = 407; // PROXY AUTHENITICATION REQUIRED

    public static readonly int HTTP_500 = 500; // INTERNAL SERVER ERROR
    public static readonly int HTTP_501 = 501; // NOT IMPLEMENTED
    public static readonly int HTTP_502 = 502; // BAD GATEWAY
    public static readonly int HTTP_503 = 503; // SERVICE UNVAILABLE





}
