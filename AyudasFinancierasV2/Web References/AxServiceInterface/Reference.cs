#pragma warning disable 1591
namespace AyudasFinancierasV2.AxServiceInterface {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AxServicesInterfaceSoap", Namespace="http://documentum.com/AX/WebServices")]
    public partial class AxServicesInterface : System.Web.Services.Protocols.SoapHttpClientProtocol {
        private AxSoapAlerts axSoapAlertsValueField;
        private System.Threading.SendOrPostCallback UpdateAnnotationFromStreamOperationCompleted;
        private System.Threading.SendOrPostCallback GetDigitalSignatureHistoryOperationCompleted;
        private System.Threading.SendOrPostCallback SignPageVersionOperationCompleted;
        private System.Threading.SendOrPostCallback GetFileInfoOperationCompleted;
        private System.Threading.SendOrPostCallback GetFileInfoByDocRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetCertificatesOperationCompleted;
        private System.Threading.SendOrPostCallback QueryDocumentIndexesOperationCompleted;
        private System.Threading.SendOrPostCallback QueryDocumentIndexesByRefOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseDocumentIndexResultsOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseDocumentIndexResultsByRefOperationCompleted;
        private System.Threading.SendOrPostCallback ApplyAutoIndexByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback ApplyAutoIndexOperationCompleted;
        private System.Threading.SendOrPostCallback ApplyAutoIndexByRefOperationCompleted;
        private System.Threading.SendOrPostCallback LookupKeyReferenceByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback LookupKeyReferenceOperationCompleted;
        private System.Threading.SendOrPostCallback LookupKeyReferenceByRefOperationCompleted;
        private System.Threading.SendOrPostCallback ModifyDocumentIndexOperationCompleted;
        private System.Threading.SendOrPostCallback ModifyDocumentIndexByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentIndexOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentIndexByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteAutoIndexOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteAutoIndexByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback SaveDocumentIndexOperationCompleted;
        private System.Threading.SendOrPostCallback SaveDocumentIndexByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentIndexOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentIndexForEditOperationCompleted;
        private System.Threading.SendOrPostCallback SaveAndReturnDocumentIndexOperationCompleted;
        private System.Threading.SendOrPostCallback SaveAndReturnDocumentIndexByRefOperationCompleted;
        private System.Threading.SendOrPostCallback SubmitFullTextJobOperationCompleted;
        private System.Threading.SendOrPostCallback SubmitFullTextJobByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextJobQueueListOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextJobListOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextHitCountOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextHitCountByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextHitInfoOperationCompleted;
        private System.Threading.SendOrPostCallback GetFullTextHitInfoByRefOperationCompleted;
        private System.Threading.SendOrPostCallback OpenBatchDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CloseBatchDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback LockBatchDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback UnlockBatchDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback UnlockBatchDocumentsOperationCompleted;
        private System.Threading.SendOrPostCallback GetBatchDocumentListByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback GetBatchDocumentListByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteBatchDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteBatchDocumentsByRefOperationCompleted;
        private System.Threading.SendOrPostCallback ChangeBatchNameByRefOperationCompleted;
        private System.Threading.SendOrPostCallback ChangeBatchMemoByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetBatchMemoByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CreateDocumentFromBatchPageByRefOperationCompleted;
        private System.Threading.SendOrPostCallback AttachBatchPagesByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CreateBatchPageOperationCompleted;
        private System.Threading.SendOrPostCallback CreateBatchPageByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetBatchPageListByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteBatchPagesOperationCompleted;
        private System.Threading.SendOrPostCallback DownloadImageStreamOperationCompleted;
        private System.Threading.SendOrPostCallback UploadImageStreamOperationCompleted;
        private System.Threading.SendOrPostCallback GetJobQueueListOperationCompleted;
        private System.Threading.SendOrPostCallback GetJobListOperationCompleted;
        private System.Threading.SendOrPostCallback GetJobElementListOperationCompleted;
        private System.Threading.SendOrPostCallback ResubmitJobsOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteJobsOperationCompleted;
        private System.Threading.SendOrPostCallback GetFAMJobStatusOperationCompleted;
        private System.Threading.SendOrPostCallback GetFAMJobErrorMsgOperationCompleted;
        private System.Threading.SendOrPostCallback LogAuditEventOperationCompleted;
        private System.Threading.SendOrPostCallback GetHookMessageOperationCompleted;
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        private AxWinCode axWinCodeValueField;
        private System.Threading.SendOrPostCallback SecuredLoginOperationCompleted;
        private System.Threading.SendOrPostCallback WindowsLoginOperationCompleted;
        private System.Threading.SendOrPostCallback LoginSetOperationCompleted;
        private System.Threading.SendOrPostCallback LogoutOperationCompleted;
        private System.Threading.SendOrPostCallback GetEncryptionKeyOperationCompleted;
        private System.Threading.SendOrPostCallback QueryUserSessionsOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseUserSessionResultsOperationCompleted;
        private System.Threading.SendOrPostCallback KillUserSessionsOperationCompleted;
        private System.Threading.SendOrPostCallback GetDataSourceNameListOperationCompleted;
        private System.Threading.SendOrPostCallback GetLoggedOnDataSourceNameListOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationListOperationCompleted;
        private System.Threading.SendOrPostCallback ChangePasswordOperationCompleted;
        private System.Threading.SendOrPostCallback SecuredChangePasswordOperationCompleted;
        private System.Threading.SendOrPostCallback GetUserPermissionsOperationCompleted;
        private System.Threading.SendOrPostCallback GetPermissionsDefinitionOperationCompleted;
        private System.Threading.SendOrPostCallback GetLicenseInfoOperationCompleted;
        private System.Threading.SendOrPostCallback GetSessionTimeoutOperationCompleted;
        private System.Threading.SendOrPostCallback GetSessionFeaturesOperationCompleted;
        private System.Threading.SendOrPostCallback GetWorkflowProviderOperationCompleted;
        private System.Threading.SendOrPostCallback GetAnnGroupSecurityMgrOperationCompleted;
        private System.Threading.SendOrPostCallback GetIrmMembersOperationCompleted;
        private System.Threading.SendOrPostCallback GetAxViewerLicenseOperationCompleted;
        private System.Threading.SendOrPostCallback GetAxUsersOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationFieldsOperationCompleted;
        private System.Threading.SendOrPostCallback GetODMAFieldsOperationCompleted;
        private System.Threading.SendOrPostCallback GetReportFieldsOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationQueriesOperationCompleted;
        private System.Threading.SendOrPostCallback GetCAQQueriesOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationsDataOperationCompleted;
        private System.Threading.SendOrPostCallback GetRetentionProviderOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationsHoldLabelsOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocIdsWithHoldLabelOperationCompleted;
        private System.Threading.SendOrPostCallback GetRetentionConfigurationOperationCompleted;
        private System.Threading.SendOrPostCallback GetApplicationBusinessProcessListOperationCompleted;
        private System.Threading.SendOrPostCallback OpenDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback OpenDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CloseDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback CloseDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CreateNewDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback CheckOutDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback CheckOutDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CheckInDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback CheckInDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback CancelCheckOutDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback CancelCheckOutDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback LockDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback LockDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback UnlockDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback UnlockDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback UnlockDocumentsByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentsOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentsByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentPageListOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentPageListByRefOperationCompleted;
        private System.Threading.SendOrPostCallback UploadDocumentPageOperationCompleted;
        private System.Threading.SendOrPostCallback UploadDocumentPageByRefOperationCompleted;
        private System.Threading.SendOrPostCallback UploadDocumentPageStreamByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentPageOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentPageByRefOperationCompleted;
        private System.Threading.SendOrPostCallback QueryCheckedOutDocumentsOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseCheckedOutDocumentResultsOperationCompleted;
        private System.Threading.SendOrPostCallback QueryLockedDocumentsOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseLockedDocumentResultsOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentPropertyOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentPropertyByRefOperationCompleted;
        private System.Threading.SendOrPostCallback SetDocumentPropertyOperationCompleted;
        private System.Threading.SendOrPostCallback SetDocumentPropertyByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentRevisionsOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentRevisionsByRefOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentRevisionOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteDocumentRevisionByRefOperationCompleted;
        private System.Threading.SendOrPostCallback MergePDFPagesOperationCompleted;
        private System.Threading.SendOrPostCallback MergePDFPagesByRefOperationCompleted;
        private System.Threading.SendOrPostCallback ExportDocumentPagesOperationCompleted;
        private System.Threading.SendOrPostCallback ExportDocumentPagesByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetExportDocumentPagesResultOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentDisplayUrlByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentDisplayUrlOperationCompleted;
        private System.Threading.SendOrPostCallback ReleaseDocumentsLockOperationCompleted;
        private System.Threading.SendOrPostCallback MoveDocumentPageOperationCompleted;
        private System.Threading.SendOrPostCallback CreateBatchFromDocumentPagesOperationCompleted;
        private System.Threading.SendOrPostCallback SetDocumentRetentionOperationCompleted;
        private System.Threading.SendOrPostCallback SetDocumentRetentionHoldOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentHoldLabelOperationCompleted;
        private System.Threading.SendOrPostCallback RemoveDocumentRetentionHoldOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentRetentionStartDateAsFiletimeOperationCompleted;
        private System.Threading.SendOrPostCallback GetDocumentRetentionEndDateAsFiletimeOperationCompleted;
        private System.Threading.SendOrPostCallback StartBusinessProcessOnDocumentOperationCompleted;
        private System.Threading.SendOrPostCallback GetIrmPolicyTemplatesOperationCompleted;
        private System.Threading.SendOrPostCallback QueryDocumentsOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseDocumentResultsOperationCompleted;
        private System.Threading.SendOrPostCallback SaveQueryOperationCompleted;
        private System.Threading.SendOrPostCallback DeleteQueryOperationCompleted;
        private System.Threading.SendOrPostCallback QueryApplicationIndexesByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback QueryApplicationIndexesByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback RequeryApplicationIndexesByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback RequeryApplicationIndexesByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseApplicationIndexResultsByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseApplicationIndexResultsByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback QueryAutoIndexesByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback QueryAutoIndexesByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseAutoIndexResultsByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback BrowseAutoIndexResultsByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback GetCAQConfigurationOperationCompleted;
        private System.Threading.SendOrPostCallback SaveCAQConfigurationOperationCompleted;
        private System.Threading.SendOrPostCallback GetRubberStampListByAppIdOperationCompleted;
        private System.Threading.SendOrPostCallback GetRubberStampListByAppNameOperationCompleted;
        private System.Threading.SendOrPostCallback GetFormOverlaysByNameOperationCompleted;
        private System.Threading.SendOrPostCallback GetFormOverlayByRefOperationCompleted;
        private System.Threading.SendOrPostCallback GetFormOverlayByIdOperationCompleted;
        private System.Threading.SendOrPostCallback GetImageFileOperationCompleted;
        private System.Threading.SendOrPostCallback GetImageStreamOperationCompleted;
        private System.Threading.SendOrPostCallback GetRubberStampFileOperationCompleted;
        private System.Threading.SendOrPostCallback GetFormOverlayFileByNameOperationCompleted;
        private System.Threading.SendOrPostCallback GetFormOverlayFileByIdOperationCompleted;
        private System.Threading.SendOrPostCallback AddPageVersionOperationCompleted;
        private System.Threading.SendOrPostCallback AddPageVersionFromStreamOperationCompleted;
        private System.Threading.SendOrPostCallback RenderPageVersionOperationCompleted;
        private System.Threading.SendOrPostCallback RenderPageVersionAsync1OperationCompleted;
        private System.Threading.SendOrPostCallback GetRenderingStatusOperationCompleted;
        private System.Threading.SendOrPostCallback GetRenderImageStreamOperationCompleted;
        private System.Threading.SendOrPostCallback DeletePageVersionOperationCompleted;
        private System.Threading.SendOrPostCallback UpdateAnnotationFileOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;
        public AxServicesInterface() {
            this.Url = global::AyudasFinancierasV2.Properties.Settings.Default.XtenderDocument_mx_edu_udem_campus_srvbdmwebdevl_AxServicesInterface;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        public AxSoapAlerts AxSoapAlertsValue {
            get {
                return this.axSoapAlertsValueField;
            }
            set {
                this.axSoapAlertsValueField = value;
            }
        }
        public AxWinCode AxWinCodeValue {
            get {
                return this.axWinCodeValueField;
            }
            set {
                this.axWinCodeValueField = value;
            }
        }
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        public event UpdateAnnotationFromStreamCompletedEventHandler UpdateAnnotationFromStreamCompleted;
        public event GetDigitalSignatureHistoryCompletedEventHandler GetDigitalSignatureHistoryCompleted;
        public event SignPageVersionCompletedEventHandler SignPageVersionCompleted;
        public event GetFileInfoCompletedEventHandler GetFileInfoCompleted;
        public event GetFileInfoByDocRefCompletedEventHandler GetFileInfoByDocRefCompleted;
        public event GetCertificatesCompletedEventHandler GetCertificatesCompleted;
        public event QueryDocumentIndexesCompletedEventHandler QueryDocumentIndexesCompleted;
        public event QueryDocumentIndexesByRefCompletedEventHandler QueryDocumentIndexesByRefCompleted;
        public event BrowseDocumentIndexResultsCompletedEventHandler BrowseDocumentIndexResultsCompleted;
        public event BrowseDocumentIndexResultsByRefCompletedEventHandler BrowseDocumentIndexResultsByRefCompleted;
        public event ApplyAutoIndexByAppIdCompletedEventHandler ApplyAutoIndexByAppIdCompleted;
        public event ApplyAutoIndexCompletedEventHandler ApplyAutoIndexCompleted;
        public event ApplyAutoIndexByRefCompletedEventHandler ApplyAutoIndexByRefCompleted;
        public event LookupKeyReferenceByAppIdCompletedEventHandler LookupKeyReferenceByAppIdCompleted;
        public event LookupKeyReferenceCompletedEventHandler LookupKeyReferenceCompleted;
        public event LookupKeyReferenceByRefCompletedEventHandler LookupKeyReferenceByRefCompleted;
        public event ModifyDocumentIndexCompletedEventHandler ModifyDocumentIndexCompleted;
        public event ModifyDocumentIndexByRefCompletedEventHandler ModifyDocumentIndexByRefCompleted;
        public event DeleteDocumentIndexCompletedEventHandler DeleteDocumentIndexCompleted;
        public event DeleteDocumentIndexByRefCompletedEventHandler DeleteDocumentIndexByRefCompleted;
        public event DeleteAutoIndexCompletedEventHandler DeleteAutoIndexCompleted;
        public event DeleteAutoIndexByAppNameCompletedEventHandler DeleteAutoIndexByAppNameCompleted;
        public event SaveDocumentIndexCompletedEventHandler SaveDocumentIndexCompleted;
        public event SaveDocumentIndexByRefCompletedEventHandler SaveDocumentIndexByRefCompleted;
        public event GetDocumentIndexCompletedEventHandler GetDocumentIndexCompleted;
        public event GetDocumentIndexForEditCompletedEventHandler GetDocumentIndexForEditCompleted;
        public event SaveAndReturnDocumentIndexCompletedEventHandler SaveAndReturnDocumentIndexCompleted;
        public event SaveAndReturnDocumentIndexByRefCompletedEventHandler SaveAndReturnDocumentIndexByRefCompleted;
        public event SubmitFullTextJobCompletedEventHandler SubmitFullTextJobCompleted;
        public event SubmitFullTextJobByRefCompletedEventHandler SubmitFullTextJobByRefCompleted;
        public event GetFullTextJobQueueListCompletedEventHandler GetFullTextJobQueueListCompleted;
        public event GetFullTextJobListCompletedEventHandler GetFullTextJobListCompleted;
        public event GetFullTextHitCountCompletedEventHandler GetFullTextHitCountCompleted;
        public event GetFullTextHitCountByRefCompletedEventHandler GetFullTextHitCountByRefCompleted;
        public event GetFullTextHitInfoCompletedEventHandler GetFullTextHitInfoCompleted;
        public event GetFullTextHitInfoByRefCompletedEventHandler GetFullTextHitInfoByRefCompleted;
        public event OpenBatchDocumentByRefCompletedEventHandler OpenBatchDocumentByRefCompleted;
        public event CloseBatchDocumentByRefCompletedEventHandler CloseBatchDocumentByRefCompleted;
        public event LockBatchDocumentByRefCompletedEventHandler LockBatchDocumentByRefCompleted;
        public event UnlockBatchDocumentCompletedEventHandler UnlockBatchDocumentCompleted;
        public event UnlockBatchDocumentsCompletedEventHandler UnlockBatchDocumentsCompleted;
        public event GetBatchDocumentListByAppIdCompletedEventHandler GetBatchDocumentListByAppIdCompleted;
        public event GetBatchDocumentListByAppNameCompletedEventHandler GetBatchDocumentListByAppNameCompleted;
        public event DeleteBatchDocumentByRefCompletedEventHandler DeleteBatchDocumentByRefCompleted;
        public event DeleteBatchDocumentsByRefCompletedEventHandler DeleteBatchDocumentsByRefCompleted;
        public event ChangeBatchNameByRefCompletedEventHandler ChangeBatchNameByRefCompleted;
        public event ChangeBatchMemoByRefCompletedEventHandler ChangeBatchMemoByRefCompleted;
        public event GetBatchMemoByRefCompletedEventHandler GetBatchMemoByRefCompleted;
        public event CreateDocumentFromBatchPageByRefCompletedEventHandler CreateDocumentFromBatchPageByRefCompleted;
        public event AttachBatchPagesByRefCompletedEventHandler AttachBatchPagesByRefCompleted;
        public event CreateBatchPageCompletedEventHandler CreateBatchPageCompleted;
        public event CreateBatchPageByRefCompletedEventHandler CreateBatchPageByRefCompleted;
        public event GetBatchPageListByRefCompletedEventHandler GetBatchPageListByRefCompleted;
        public event DeleteBatchPagesCompletedEventHandler DeleteBatchPagesCompleted;
        public event DownloadImageStreamCompletedEventHandler DownloadImageStreamCompleted;
        public event UploadImageStreamCompletedEventHandler UploadImageStreamCompleted;
        public event GetJobQueueListCompletedEventHandler GetJobQueueListCompleted;
        public event GetJobListCompletedEventHandler GetJobListCompleted;
        public event GetJobElementListCompletedEventHandler GetJobElementListCompleted;
        public event ResubmitJobsCompletedEventHandler ResubmitJobsCompleted;
        public event DeleteJobsCompletedEventHandler DeleteJobsCompleted;
        public event GetFAMJobStatusCompletedEventHandler GetFAMJobStatusCompleted;
        public event GetFAMJobErrorMsgCompletedEventHandler GetFAMJobErrorMsgCompleted;
        public event LogAuditEventCompletedEventHandler LogAuditEventCompleted;
        public event GetHookMessageCompletedEventHandler GetHookMessageCompleted;
        public event LoginCompletedEventHandler LoginCompleted;
        public event SecuredLoginCompletedEventHandler SecuredLoginCompleted;
        public event WindowsLoginCompletedEventHandler WindowsLoginCompleted;
        public event LoginSetCompletedEventHandler LoginSetCompleted;
        public event LogoutCompletedEventHandler LogoutCompleted;
        public event GetEncryptionKeyCompletedEventHandler GetEncryptionKeyCompleted;
        public event QueryUserSessionsCompletedEventHandler QueryUserSessionsCompleted;
        public event BrowseUserSessionResultsCompletedEventHandler BrowseUserSessionResultsCompleted;
        public event KillUserSessionsCompletedEventHandler KillUserSessionsCompleted;
        public event GetDataSourceNameListCompletedEventHandler GetDataSourceNameListCompleted;
        public event GetLoggedOnDataSourceNameListCompletedEventHandler GetLoggedOnDataSourceNameListCompleted;
        public event GetApplicationListCompletedEventHandler GetApplicationListCompleted;
        public event ChangePasswordCompletedEventHandler ChangePasswordCompleted;
        public event SecuredChangePasswordCompletedEventHandler SecuredChangePasswordCompleted;
        public event GetUserPermissionsCompletedEventHandler GetUserPermissionsCompleted;
        public event GetPermissionsDefinitionCompletedEventHandler GetPermissionsDefinitionCompleted;
        public event GetLicenseInfoCompletedEventHandler GetLicenseInfoCompleted;
        public event GetSessionTimeoutCompletedEventHandler GetSessionTimeoutCompleted;
        public event GetSessionFeaturesCompletedEventHandler GetSessionFeaturesCompleted;
        public event GetWorkflowProviderCompletedEventHandler GetWorkflowProviderCompleted;
        public event GetAnnGroupSecurityMgrCompletedEventHandler GetAnnGroupSecurityMgrCompleted;
        public event GetIrmMembersCompletedEventHandler GetIrmMembersCompleted;
        public event GetAxViewerLicenseCompletedEventHandler GetAxViewerLicenseCompleted;
        public event GetAxUsersCompletedEventHandler GetAxUsersCompleted;
        public event GetApplicationFieldsCompletedEventHandler GetApplicationFieldsCompleted;
        public event GetODMAFieldsCompletedEventHandler GetODMAFieldsCompleted;
        public event GetReportFieldsCompletedEventHandler GetReportFieldsCompleted;
        public event GetApplicationQueriesCompletedEventHandler GetApplicationQueriesCompleted;
        public event GetCAQQueriesCompletedEventHandler GetCAQQueriesCompleted;
        public event GetApplicationsDataCompletedEventHandler GetApplicationsDataCompleted;
        public event GetRetentionProviderCompletedEventHandler GetRetentionProviderCompleted;
        public event GetApplicationsHoldLabelsCompletedEventHandler GetApplicationsHoldLabelsCompleted;
        public event GetDocIdsWithHoldLabelCompletedEventHandler GetDocIdsWithHoldLabelCompleted;
        public event GetRetentionConfigurationCompletedEventHandler GetRetentionConfigurationCompleted;
        public event GetApplicationBusinessProcessListCompletedEventHandler GetApplicationBusinessProcessListCompleted;
        public event OpenDocumentCompletedEventHandler OpenDocumentCompleted;
        public event OpenDocumentByRefCompletedEventHandler OpenDocumentByRefCompleted;
        public event CloseDocumentCompletedEventHandler CloseDocumentCompleted;
        public event CloseDocumentByRefCompletedEventHandler CloseDocumentByRefCompleted;
        public event CreateNewDocumentCompletedEventHandler CreateNewDocumentCompleted;
        public event CheckOutDocumentCompletedEventHandler CheckOutDocumentCompleted;
        public event CheckOutDocumentByRefCompletedEventHandler CheckOutDocumentByRefCompleted;
        public event CheckInDocumentCompletedEventHandler CheckInDocumentCompleted;
        public event CheckInDocumentByRefCompletedEventHandler CheckInDocumentByRefCompleted;
        public event CancelCheckOutDocumentCompletedEventHandler CancelCheckOutDocumentCompleted;
        public event CancelCheckOutDocumentByRefCompletedEventHandler CancelCheckOutDocumentByRefCompleted;
        public event LockDocumentCompletedEventHandler LockDocumentCompleted;
        public event LockDocumentByRefCompletedEventHandler LockDocumentByRefCompleted;
        public event UnlockDocumentCompletedEventHandler UnlockDocumentCompleted;
        public event UnlockDocumentByRefCompletedEventHandler UnlockDocumentByRefCompleted;
        public event UnlockDocumentsByRefCompletedEventHandler UnlockDocumentsByRefCompleted;
        public event DeleteDocumentCompletedEventHandler DeleteDocumentCompleted;
        public event DeleteDocumentByRefCompletedEventHandler DeleteDocumentByRefCompleted;
        public event DeleteDocumentsCompletedEventHandler DeleteDocumentsCompleted;
        public event DeleteDocumentsByRefCompletedEventHandler DeleteDocumentsByRefCompleted;
        public event GetDocumentPageListCompletedEventHandler GetDocumentPageListCompleted;
        public event GetDocumentPageListByRefCompletedEventHandler GetDocumentPageListByRefCompleted;
        public event UploadDocumentPageCompletedEventHandler UploadDocumentPageCompleted;
        public event UploadDocumentPageByRefCompletedEventHandler UploadDocumentPageByRefCompleted;
        public event UploadDocumentPageStreamByRefCompletedEventHandler UploadDocumentPageStreamByRefCompleted;
        public event DeleteDocumentPageCompletedEventHandler DeleteDocumentPageCompleted;
        public event DeleteDocumentPageByRefCompletedEventHandler DeleteDocumentPageByRefCompleted;
        public event QueryCheckedOutDocumentsCompletedEventHandler QueryCheckedOutDocumentsCompleted;
        public event BrowseCheckedOutDocumentResultsCompletedEventHandler BrowseCheckedOutDocumentResultsCompleted;
        public event QueryLockedDocumentsCompletedEventHandler QueryLockedDocumentsCompleted;
        public event BrowseLockedDocumentResultsCompletedEventHandler BrowseLockedDocumentResultsCompleted;
        public event GetDocumentPropertyCompletedEventHandler GetDocumentPropertyCompleted;
        public event GetDocumentPropertyByRefCompletedEventHandler GetDocumentPropertyByRefCompleted;
        public event SetDocumentPropertyCompletedEventHandler SetDocumentPropertyCompleted;
        public event SetDocumentPropertyByRefCompletedEventHandler SetDocumentPropertyByRefCompleted;
        public event GetDocumentRevisionsCompletedEventHandler GetDocumentRevisionsCompleted;
        public event GetDocumentRevisionsByRefCompletedEventHandler GetDocumentRevisionsByRefCompleted;
        public event DeleteDocumentRevisionCompletedEventHandler DeleteDocumentRevisionCompleted;
        public event DeleteDocumentRevisionByRefCompletedEventHandler DeleteDocumentRevisionByRefCompleted;
        public event MergePDFPagesCompletedEventHandler MergePDFPagesCompleted;
        public event MergePDFPagesByRefCompletedEventHandler MergePDFPagesByRefCompleted;
        public event ExportDocumentPagesCompletedEventHandler ExportDocumentPagesCompleted;
        public event ExportDocumentPagesByRefCompletedEventHandler ExportDocumentPagesByRefCompleted;
        public event GetExportDocumentPagesResultCompletedEventHandler GetExportDocumentPagesResultCompleted;
        public event GetDocumentDisplayUrlByRefCompletedEventHandler GetDocumentDisplayUrlByRefCompleted;
        public event GetDocumentDisplayUrlCompletedEventHandler GetDocumentDisplayUrlCompleted;
        public event ReleaseDocumentsLockCompletedEventHandler ReleaseDocumentsLockCompleted;
        public event MoveDocumentPageCompletedEventHandler MoveDocumentPageCompleted;
        public event CreateBatchFromDocumentPagesCompletedEventHandler CreateBatchFromDocumentPagesCompleted;
        public event SetDocumentRetentionCompletedEventHandler SetDocumentRetentionCompleted;
        public event SetDocumentRetentionHoldCompletedEventHandler SetDocumentRetentionHoldCompleted;
        public event GetDocumentHoldLabelCompletedEventHandler GetDocumentHoldLabelCompleted;
        public event RemoveDocumentRetentionHoldCompletedEventHandler RemoveDocumentRetentionHoldCompleted;
        public event GetDocumentRetentionStartDateAsFiletimeCompletedEventHandler GetDocumentRetentionStartDateAsFiletimeCompleted;
        public event GetDocumentRetentionEndDateAsFiletimeCompletedEventHandler GetDocumentRetentionEndDateAsFiletimeCompleted;
        public event StartBusinessProcessOnDocumentCompletedEventHandler StartBusinessProcessOnDocumentCompleted;
        public event GetIrmPolicyTemplatesCompletedEventHandler GetIrmPolicyTemplatesCompleted;
        public event QueryDocumentsCompletedEventHandler QueryDocumentsCompleted;
        public event BrowseDocumentResultsCompletedEventHandler BrowseDocumentResultsCompleted;
        public event SaveQueryCompletedEventHandler SaveQueryCompleted;
        public event DeleteQueryCompletedEventHandler DeleteQueryCompleted;
        public event QueryApplicationIndexesByAppIdCompletedEventHandler QueryApplicationIndexesByAppIdCompleted;
        public event QueryApplicationIndexesByAppNameCompletedEventHandler QueryApplicationIndexesByAppNameCompleted;
        public event RequeryApplicationIndexesByAppIdCompletedEventHandler RequeryApplicationIndexesByAppIdCompleted;
        public event RequeryApplicationIndexesByAppNameCompletedEventHandler RequeryApplicationIndexesByAppNameCompleted;
        public event BrowseApplicationIndexResultsByAppIdCompletedEventHandler BrowseApplicationIndexResultsByAppIdCompleted;
        public event BrowseApplicationIndexResultsByAppNameCompletedEventHandler BrowseApplicationIndexResultsByAppNameCompleted;
        public event QueryAutoIndexesByAppIdCompletedEventHandler QueryAutoIndexesByAppIdCompleted;
        public event QueryAutoIndexesByAppNameCompletedEventHandler QueryAutoIndexesByAppNameCompleted;
        public event BrowseAutoIndexResultsByAppIdCompletedEventHandler BrowseAutoIndexResultsByAppIdCompleted;
        public event BrowseAutoIndexResultsByAppNameCompletedEventHandler BrowseAutoIndexResultsByAppNameCompleted;
        public event GetCAQConfigurationCompletedEventHandler GetCAQConfigurationCompleted;
        public event SaveCAQConfigurationCompletedEventHandler SaveCAQConfigurationCompleted;
        public event GetRubberStampListByAppIdCompletedEventHandler GetRubberStampListByAppIdCompleted;
        public event GetRubberStampListByAppNameCompletedEventHandler GetRubberStampListByAppNameCompleted;
        public event GetFormOverlaysByNameCompletedEventHandler GetFormOverlaysByNameCompleted;
        public event GetFormOverlayByRefCompletedEventHandler GetFormOverlayByRefCompleted;
        public event GetFormOverlayByIdCompletedEventHandler GetFormOverlayByIdCompleted;
        public event GetImageFileCompletedEventHandler GetImageFileCompleted;
        public event GetImageStreamCompletedEventHandler GetImageStreamCompleted;
        public event GetRubberStampFileCompletedEventHandler GetRubberStampFileCompleted;
        public event GetFormOverlayFileByNameCompletedEventHandler GetFormOverlayFileByNameCompleted;
        public event GetFormOverlayFileByIdCompletedEventHandler GetFormOverlayFileByIdCompleted;
        public event AddPageVersionCompletedEventHandler AddPageVersionCompleted;
        public event AddPageVersionFromStreamCompletedEventHandler AddPageVersionFromStreamCompleted;
        public event RenderPageVersionCompletedEventHandler RenderPageVersionCompleted;
        public event RenderPageVersionAsync1CompletedEventHandler RenderPageVersionAsync1Completed;
        public event GetRenderingStatusCompletedEventHandler GetRenderingStatusCompleted;
        public event GetRenderImageStreamCompletedEventHandler GetRenderImageStreamCompleted;
        public event DeletePageVersionCompletedEventHandler DeletePageVersionCompleted;
        public event UpdateAnnotationFileCompletedEventHandler UpdateAnnotationFileCompleted;
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UpdateAnnotationFromStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateAnnotationFromStream(string sessionTicket, string pageRef, short version, string xmlAxStreamData) {
            object[] results = this.Invoke("UpdateAnnotationFromStream", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        xmlAxStreamData});
            return ((string)(results[0]));
        }
        public void UpdateAnnotationFromStreamAsync(string sessionTicket, string pageRef, short version, string xmlAxStreamData) {
            this.UpdateAnnotationFromStreamAsync(sessionTicket, pageRef, version, xmlAxStreamData, null);
        }
        public void UpdateAnnotationFromStreamAsync(string sessionTicket, string pageRef, short version, string xmlAxStreamData, object userState) {
            if ((this.UpdateAnnotationFromStreamOperationCompleted == null)) {
                this.UpdateAnnotationFromStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateAnnotationFromStreamOperationCompleted);
            }
            this.InvokeAsync("UpdateAnnotationFromStream", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        xmlAxStreamData}, this.UpdateAnnotationFromStreamOperationCompleted, userState);
        }
        private void OnUpdateAnnotationFromStreamOperationCompleted(object arg) {
            if ((this.UpdateAnnotationFromStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateAnnotationFromStreamCompleted(this, new UpdateAnnotationFromStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDigitalSignatureHistory", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDigitalSignatureHistory(string sessionTicket, string pageRef, short version) {
            object[] results = this.Invoke("GetDigitalSignatureHistory", new object[] {
                        sessionTicket,
                        pageRef,
                        version});
            return ((string)(results[0]));
        }
        public void GetDigitalSignatureHistoryAsync(string sessionTicket, string pageRef, short version) {
            this.GetDigitalSignatureHistoryAsync(sessionTicket, pageRef, version, null);
        }
        public void GetDigitalSignatureHistoryAsync(string sessionTicket, string pageRef, short version, object userState) {
            if ((this.GetDigitalSignatureHistoryOperationCompleted == null)) {
                this.GetDigitalSignatureHistoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDigitalSignatureHistoryOperationCompleted);
            }
            this.InvokeAsync("GetDigitalSignatureHistory", new object[] {
                        sessionTicket,
                        pageRef,
                        version}, this.GetDigitalSignatureHistoryOperationCompleted, userState);
        }
        private void OnGetDigitalSignatureHistoryOperationCompleted(object arg) {
            if ((this.GetDigitalSignatureHistoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDigitalSignatureHistoryCompleted(this, new GetDigitalSignatureHistoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SignPageVersion", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SignPageVersion(string sessionTicket, string pageRef, short version, string xmlSignatureData) {
            this.Invoke("SignPageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        xmlSignatureData});
        }
        public void SignPageVersionAsync(string sessionTicket, string pageRef, short version, string xmlSignatureData) {
            this.SignPageVersionAsync(sessionTicket, pageRef, version, xmlSignatureData, null);
        }
        public void SignPageVersionAsync(string sessionTicket, string pageRef, short version, string xmlSignatureData, object userState) {
            if ((this.SignPageVersionOperationCompleted == null)) {
                this.SignPageVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSignPageVersionOperationCompleted);
            }
            this.InvokeAsync("SignPageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        xmlSignatureData}, this.SignPageVersionOperationCompleted, userState);
        }
        private void OnSignPageVersionOperationCompleted(object arg) {
            if ((this.SignPageVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SignPageVersionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFileInfo", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFileInfo(string sessionTicket, string pageRef, short version) {
            object[] results = this.Invoke("GetFileInfo", new object[] {
                        sessionTicket,
                        pageRef,
                        version});
            return ((string)(results[0]));
        }
        public void GetFileInfoAsync(string sessionTicket, string pageRef, short version) {
            this.GetFileInfoAsync(sessionTicket, pageRef, version, null);
        }
        public void GetFileInfoAsync(string sessionTicket, string pageRef, short version, object userState) {
            if ((this.GetFileInfoOperationCompleted == null)) {
                this.GetFileInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileInfoOperationCompleted);
            }
            this.InvokeAsync("GetFileInfo", new object[] {
                        sessionTicket,
                        pageRef,
                        version}, this.GetFileInfoOperationCompleted, userState);
        }
        private void OnGetFileInfoOperationCompleted(object arg) {
            if ((this.GetFileInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileInfoCompleted(this, new GetFileInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFileInfoByDocRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFileInfoByDocRef(string sessionTicket, string docRef, int page, short version) {
            object[] results = this.Invoke("GetFileInfoByDocRef", new object[] {
                        sessionTicket,
                        docRef,
                        page,
                        version});
            return ((string)(results[0]));
        }
        public void GetFileInfoByDocRefAsync(string sessionTicket, string docRef, int page, short version) {
            this.GetFileInfoByDocRefAsync(sessionTicket, docRef, page, version, null);
        }
        public void GetFileInfoByDocRefAsync(string sessionTicket, string docRef, int page, short version, object userState) {
            if ((this.GetFileInfoByDocRefOperationCompleted == null)) {
                this.GetFileInfoByDocRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileInfoByDocRefOperationCompleted);
            }
            this.InvokeAsync("GetFileInfoByDocRef", new object[] {
                        sessionTicket,
                        docRef,
                        page,
                        version}, this.GetFileInfoByDocRefOperationCompleted, userState);
        }
        private void OnGetFileInfoByDocRefOperationCompleted(object arg) {
            if ((this.GetFileInfoByDocRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileInfoByDocRefCompleted(this, new GetFileInfoByDocRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetCertificates", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCertificates(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetCertificates", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetCertificatesAsync(string sessionTicket, string dataSource) {
            this.GetCertificatesAsync(sessionTicket, dataSource, null);
        }
        public void GetCertificatesAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetCertificatesOperationCompleted == null)) {
                this.GetCertificatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCertificatesOperationCompleted);
            }
            this.InvokeAsync("GetCertificates", new object[] {
                        sessionTicket,
                        dataSource}, this.GetCertificatesOperationCompleted, userState);
        }
        private void OnGetCertificatesOperationCompleted(object arg) {
            if ((this.GetCertificatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCertificatesCompleted(this, new GetCertificatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryDocumentIndexes", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryDocumentIndexes(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryDocumentIndexes", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryDocumentIndexesAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize, int maxHits) {
            this.QueryDocumentIndexesAsync(sessionTicket, xmlAxDocumentPointer, startPosition, pageSize, maxHits, null);
        }
        public void QueryDocumentIndexesAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryDocumentIndexesOperationCompleted == null)) {
                this.QueryDocumentIndexesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryDocumentIndexesOperationCompleted);
            }
            this.InvokeAsync("QueryDocumentIndexes", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryDocumentIndexesOperationCompleted, userState);
        }
        private void OnQueryDocumentIndexesOperationCompleted(object arg) {
            if ((this.QueryDocumentIndexesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryDocumentIndexesCompleted(this, new QueryDocumentIndexesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryDocumentIndexesByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryDocumentIndexesByRef(string sessionTicket, string docReference, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryDocumentIndexesByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryDocumentIndexesByRefAsync(string sessionTicket, string docReference, int startPosition, int pageSize, int maxHits) {
            this.QueryDocumentIndexesByRefAsync(sessionTicket, docReference, startPosition, pageSize, maxHits, null);
        }
        public void QueryDocumentIndexesByRefAsync(string sessionTicket, string docReference, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryDocumentIndexesByRefOperationCompleted == null)) {
                this.QueryDocumentIndexesByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryDocumentIndexesByRefOperationCompleted);
            }
            this.InvokeAsync("QueryDocumentIndexesByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryDocumentIndexesByRefOperationCompleted, userState);
        }
        private void OnQueryDocumentIndexesByRefOperationCompleted(object arg) {
            if ((this.QueryDocumentIndexesByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryDocumentIndexesByRefCompleted(this, new QueryDocumentIndexesByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseDocumentIndexResults", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseDocumentIndexResults(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseDocumentIndexResults", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseDocumentIndexResultsAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize) {
            this.BrowseDocumentIndexResultsAsync(sessionTicket, xmlAxDocumentPointer, startPosition, pageSize, null);
        }
        public void BrowseDocumentIndexResultsAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageSize, object userState) {
            if ((this.BrowseDocumentIndexResultsOperationCompleted == null)) {
                this.BrowseDocumentIndexResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseDocumentIndexResultsOperationCompleted);
            }
            this.InvokeAsync("BrowseDocumentIndexResults", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageSize}, this.BrowseDocumentIndexResultsOperationCompleted, userState);
        }
        private void OnBrowseDocumentIndexResultsOperationCompleted(object arg) {
            if ((this.BrowseDocumentIndexResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseDocumentIndexResultsCompleted(this, new BrowseDocumentIndexResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseDocumentIndexResultsByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseDocumentIndexResultsByRef(string sessionTicket, string docReference, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseDocumentIndexResultsByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseDocumentIndexResultsByRefAsync(string sessionTicket, string docReference, int startPosition, int pageSize) {
            this.BrowseDocumentIndexResultsByRefAsync(sessionTicket, docReference, startPosition, pageSize, null);
        }
        public void BrowseDocumentIndexResultsByRefAsync(string sessionTicket, string docReference, int startPosition, int pageSize, object userState) {
            if ((this.BrowseDocumentIndexResultsByRefOperationCompleted == null)) {
                this.BrowseDocumentIndexResultsByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseDocumentIndexResultsByRefOperationCompleted);
            }
            this.InvokeAsync("BrowseDocumentIndexResultsByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageSize}, this.BrowseDocumentIndexResultsByRefOperationCompleted, userState);
        }
        private void OnBrowseDocumentIndexResultsByRefOperationCompleted(object arg) {
            if ((this.BrowseDocumentIndexResultsByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseDocumentIndexResultsByRefCompleted(this, new BrowseDocumentIndexResultsByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ApplyAutoIndexByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ApplyAutoIndexByAppId(string sessionTicket, string dataSource, short appId, string xmlNew_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            object[] results = this.Invoke("ApplyAutoIndexByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlNew_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex});
            return ((string)(results[0]));
        }
        public void ApplyAutoIndexByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlNew_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            this.ApplyAutoIndexByAppIdAsync(sessionTicket, dataSource, appId, xmlNew_AxDocumentIndex, xmlAuto_AxDocumentIndex, null);
        }
        public void ApplyAutoIndexByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlNew_AxDocumentIndex, string xmlAuto_AxDocumentIndex, object userState) {
            if ((this.ApplyAutoIndexByAppIdOperationCompleted == null)) {
                this.ApplyAutoIndexByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplyAutoIndexByAppIdOperationCompleted);
            }
            this.InvokeAsync("ApplyAutoIndexByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlNew_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex}, this.ApplyAutoIndexByAppIdOperationCompleted, userState);
        }
        private void OnApplyAutoIndexByAppIdOperationCompleted(object arg) {
            if ((this.ApplyAutoIndexByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ApplyAutoIndexByAppIdCompleted(this, new ApplyAutoIndexByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ApplyAutoIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ApplyAutoIndex(string sessionTicket, string xmlAxDocumentPointer, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            object[] results = this.Invoke("ApplyAutoIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlOrg_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex});
            return ((string)(results[0]));
        }
        public void ApplyAutoIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            this.ApplyAutoIndexAsync(sessionTicket, xmlAxDocumentPointer, xmlOrg_AxDocumentIndex, xmlAuto_AxDocumentIndex, null);
        }
        public void ApplyAutoIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex, object userState) {
            if ((this.ApplyAutoIndexOperationCompleted == null)) {
                this.ApplyAutoIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplyAutoIndexOperationCompleted);
            }
            this.InvokeAsync("ApplyAutoIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlOrg_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex}, this.ApplyAutoIndexOperationCompleted, userState);
        }
        private void OnApplyAutoIndexOperationCompleted(object arg) {
            if ((this.ApplyAutoIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ApplyAutoIndexCompleted(this, new ApplyAutoIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ApplyAutoIndexByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ApplyAutoIndexByRef(string sessionTicket, string docRef, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            object[] results = this.Invoke("ApplyAutoIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlOrg_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex});
            return ((string)(results[0]));
        }
        public void ApplyAutoIndexByRefAsync(string sessionTicket, string docRef, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex) {
            this.ApplyAutoIndexByRefAsync(sessionTicket, docRef, xmlOrg_AxDocumentIndex, xmlAuto_AxDocumentIndex, null);
        }
        public void ApplyAutoIndexByRefAsync(string sessionTicket, string docRef, string xmlOrg_AxDocumentIndex, string xmlAuto_AxDocumentIndex, object userState) {
            if ((this.ApplyAutoIndexByRefOperationCompleted == null)) {
                this.ApplyAutoIndexByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplyAutoIndexByRefOperationCompleted);
            }
            this.InvokeAsync("ApplyAutoIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlOrg_AxDocumentIndex,
                        xmlAuto_AxDocumentIndex}, this.ApplyAutoIndexByRefOperationCompleted, userState);
        }
        private void OnApplyAutoIndexByRefOperationCompleted(object arg) {
            if ((this.ApplyAutoIndexByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ApplyAutoIndexByRefCompleted(this, new ApplyAutoIndexByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LookupKeyReferenceByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LookupKeyReferenceByAppId(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndex) {
            object[] results = this.Invoke("LookupKeyReferenceByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxDocumentIndex});
            return ((string)(results[0]));
        }
        public void LookupKeyReferenceByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndex) {
            this.LookupKeyReferenceByAppIdAsync(sessionTicket, dataSource, appId, xmlAxDocumentIndex, null);
        }
        public void LookupKeyReferenceByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndex, object userState) {
            if ((this.LookupKeyReferenceByAppIdOperationCompleted == null)) {
                this.LookupKeyReferenceByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLookupKeyReferenceByAppIdOperationCompleted);
            }
            this.InvokeAsync("LookupKeyReferenceByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxDocumentIndex}, this.LookupKeyReferenceByAppIdOperationCompleted, userState);
        }
        private void OnLookupKeyReferenceByAppIdOperationCompleted(object arg) {
            if ((this.LookupKeyReferenceByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LookupKeyReferenceByAppIdCompleted(this, new LookupKeyReferenceByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LookupKeyReference", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LookupKeyReference(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex) {
            object[] results = this.Invoke("LookupKeyReference", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex});
            return ((string)(results[0]));
        }
        public void LookupKeyReferenceAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex) {
            this.LookupKeyReferenceAsync(sessionTicket, xmlAxDocumentPointer, xmlAxDocumentIndex, null);
        }
        public void LookupKeyReferenceAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, object userState) {
            if ((this.LookupKeyReferenceOperationCompleted == null)) {
                this.LookupKeyReferenceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLookupKeyReferenceOperationCompleted);
            }
            this.InvokeAsync("LookupKeyReference", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex}, this.LookupKeyReferenceOperationCompleted, userState);
        }
        private void OnLookupKeyReferenceOperationCompleted(object arg) {
            if ((this.LookupKeyReferenceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LookupKeyReferenceCompleted(this, new LookupKeyReferenceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LookupKeyReferenceByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LookupKeyReferenceByRef(string sessionTicket, string docRef, string xmlAxDocumentIndex) {
            object[] results = this.Invoke("LookupKeyReferenceByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex});
            return ((string)(results[0]));
        }
        public void LookupKeyReferenceByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex) {
            this.LookupKeyReferenceByRefAsync(sessionTicket, docRef, xmlAxDocumentIndex, null);
        }
        public void LookupKeyReferenceByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex, object userState) {
            if ((this.LookupKeyReferenceByRefOperationCompleted == null)) {
                this.LookupKeyReferenceByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLookupKeyReferenceByRefOperationCompleted);
            }
            this.InvokeAsync("LookupKeyReferenceByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex}, this.LookupKeyReferenceByRefOperationCompleted, userState);
        }
        private void OnLookupKeyReferenceByRefOperationCompleted(object arg) {
            if ((this.LookupKeyReferenceByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LookupKeyReferenceByRefCompleted(this, new LookupKeyReferenceByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ModifyDocumentIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ModifyDocumentIndex(string sessionTicket, string xmlAxDocumentPointer, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("ModifyDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        rsID,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void ModifyDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.ModifyDocumentIndexAsync(sessionTicket, xmlAxDocumentPointer, rsID, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void ModifyDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.ModifyDocumentIndexOperationCompleted == null)) {
                this.ModifyDocumentIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnModifyDocumentIndexOperationCompleted);
            }
            this.InvokeAsync("ModifyDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        rsID,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.ModifyDocumentIndexOperationCompleted, userState);
        }
        private void OnModifyDocumentIndexOperationCompleted(object arg) {
            if ((this.ModifyDocumentIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ModifyDocumentIndexCompleted(this, new ModifyDocumentIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ModifyDocumentIndexByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ModifyDocumentIndexByRef(string sessionTicket, string docRef, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("ModifyDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        rsID,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void ModifyDocumentIndexByRefAsync(string sessionTicket, string docRef, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.ModifyDocumentIndexByRefAsync(sessionTicket, docRef, rsID, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void ModifyDocumentIndexByRefAsync(string sessionTicket, string docRef, int rsID, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.ModifyDocumentIndexByRefOperationCompleted == null)) {
                this.ModifyDocumentIndexByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnModifyDocumentIndexByRefOperationCompleted);
            }
            this.InvokeAsync("ModifyDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        rsID,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.ModifyDocumentIndexByRefOperationCompleted, userState);
        }
        private void OnModifyDocumentIndexByRefOperationCompleted(object arg) {
            if ((this.ModifyDocumentIndexByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ModifyDocumentIndexByRefCompleted(this, new ModifyDocumentIndexByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentIndex(string sessionTicket, string xmlAxDocumentPointer, int rsID) {
            object[] results = this.Invoke("DeleteDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        rsID});
            return ((string)(results[0]));
        }
        public void DeleteDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, int rsID) {
            this.DeleteDocumentIndexAsync(sessionTicket, xmlAxDocumentPointer, rsID, null);
        }
        public void DeleteDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, int rsID, object userState) {
            if ((this.DeleteDocumentIndexOperationCompleted == null)) {
                this.DeleteDocumentIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentIndexOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        rsID}, this.DeleteDocumentIndexOperationCompleted, userState);
        }
        private void OnDeleteDocumentIndexOperationCompleted(object arg) {
            if ((this.DeleteDocumentIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentIndexCompleted(this, new DeleteDocumentIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentIndexByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentIndexByRef(string sessionTicket, string docRef, int rsID) {
            object[] results = this.Invoke("DeleteDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        rsID});
            return ((string)(results[0]));
        }
        public void DeleteDocumentIndexByRefAsync(string sessionTicket, string docRef, int rsID) {
            this.DeleteDocumentIndexByRefAsync(sessionTicket, docRef, rsID, null);
        }
        public void DeleteDocumentIndexByRefAsync(string sessionTicket, string docRef, int rsID, object userState) {
            if ((this.DeleteDocumentIndexByRefOperationCompleted == null)) {
                this.DeleteDocumentIndexByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentIndexByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        rsID}, this.DeleteDocumentIndexByRefOperationCompleted, userState);
        }
        private void OnDeleteDocumentIndexByRefOperationCompleted(object arg) {
            if ((this.DeleteDocumentIndexByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentIndexByRefCompleted(this, new DeleteDocumentIndexByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteAutoIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteAutoIndex(string sessionTicket, string dataSource, short appId, int rsID) {
            this.Invoke("DeleteAutoIndex", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        rsID});
        }
        public void DeleteAutoIndexAsync(string sessionTicket, string dataSource, short appId, int rsID) {
            this.DeleteAutoIndexAsync(sessionTicket, dataSource, appId, rsID, null);
        }
        public void DeleteAutoIndexAsync(string sessionTicket, string dataSource, short appId, int rsID, object userState) {
            if ((this.DeleteAutoIndexOperationCompleted == null)) {
                this.DeleteAutoIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteAutoIndexOperationCompleted);
            }
            this.InvokeAsync("DeleteAutoIndex", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        rsID}, this.DeleteAutoIndexOperationCompleted, userState);
        }
        private void OnDeleteAutoIndexOperationCompleted(object arg) {
            if ((this.DeleteAutoIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteAutoIndexCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteAutoIndexByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteAutoIndexByAppName(string sessionTicket, string dataSource, string appName, int rsID) {
            this.Invoke("DeleteAutoIndexByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        rsID});
        }
        public void DeleteAutoIndexByAppNameAsync(string sessionTicket, string dataSource, string appName, int rsID) {
            this.DeleteAutoIndexByAppNameAsync(sessionTicket, dataSource, appName, rsID, null);
        }
        public void DeleteAutoIndexByAppNameAsync(string sessionTicket, string dataSource, string appName, int rsID, object userState) {
            if ((this.DeleteAutoIndexByAppNameOperationCompleted == null)) {
                this.DeleteAutoIndexByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteAutoIndexByAppNameOperationCompleted);
            }
            this.InvokeAsync("DeleteAutoIndexByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        rsID}, this.DeleteAutoIndexByAppNameOperationCompleted, userState);
        }
        private void OnDeleteAutoIndexByAppNameOperationCompleted(object arg) {
            if ((this.DeleteAutoIndexByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteAutoIndexByAppNameCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveDocumentIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveDocumentIndex(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("SaveDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void SaveDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.SaveDocumentIndexAsync(sessionTicket, xmlAxDocumentPointer, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void SaveDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.SaveDocumentIndexOperationCompleted == null)) {
                this.SaveDocumentIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveDocumentIndexOperationCompleted);
            }
            this.InvokeAsync("SaveDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.SaveDocumentIndexOperationCompleted, userState);
        }
        private void OnSaveDocumentIndexOperationCompleted(object arg) {
            if ((this.SaveDocumentIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveDocumentIndexCompleted(this, new SaveDocumentIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveDocumentIndexByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveDocumentIndexByRef(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("SaveDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void SaveDocumentIndexByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.SaveDocumentIndexByRefAsync(sessionTicket, docRef, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void SaveDocumentIndexByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.SaveDocumentIndexByRefOperationCompleted == null)) {
                this.SaveDocumentIndexByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveDocumentIndexByRefOperationCompleted);
            }
            this.InvokeAsync("SaveDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.SaveDocumentIndexByRefOperationCompleted, userState);
        }
        private void OnSaveDocumentIndexByRefOperationCompleted(object arg) {
            if ((this.SaveDocumentIndexByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveDocumentIndexByRefCompleted(this, new SaveDocumentIndexByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentIndex(string sessionTicket, string docRef, int rsID) {
            object[] results = this.Invoke("GetDocumentIndex", new object[] {
                        sessionTicket,
                        docRef,
                        rsID});
            return ((string)(results[0]));
        }
        public void GetDocumentIndexAsync(string sessionTicket, string docRef, int rsID) {
            this.GetDocumentIndexAsync(sessionTicket, docRef, rsID, null);
        }
        public void GetDocumentIndexAsync(string sessionTicket, string docRef, int rsID, object userState) {
            if ((this.GetDocumentIndexOperationCompleted == null)) {
                this.GetDocumentIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentIndexOperationCompleted);
            }
            this.InvokeAsync("GetDocumentIndex", new object[] {
                        sessionTicket,
                        docRef,
                        rsID}, this.GetDocumentIndexOperationCompleted, userState);
        }
        private void OnGetDocumentIndexOperationCompleted(object arg) {
            if ((this.GetDocumentIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentIndexCompleted(this, new GetDocumentIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentIndexForEdit", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentIndexForEdit(string sessionTicket, string docRef, int rsID) {
            object[] results = this.Invoke("GetDocumentIndexForEdit", new object[] {
                        sessionTicket,
                        docRef,
                        rsID});
            return ((string)(results[0]));
        }
        public void GetDocumentIndexForEditAsync(string sessionTicket, string docRef, int rsID) {
            this.GetDocumentIndexForEditAsync(sessionTicket, docRef, rsID, null);
        }
        public void GetDocumentIndexForEditAsync(string sessionTicket, string docRef, int rsID, object userState) {
            if ((this.GetDocumentIndexForEditOperationCompleted == null)) {
                this.GetDocumentIndexForEditOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentIndexForEditOperationCompleted);
            }
            this.InvokeAsync("GetDocumentIndexForEdit", new object[] {
                        sessionTicket,
                        docRef,
                        rsID}, this.GetDocumentIndexForEditOperationCompleted, userState);
        }
        private void OnGetDocumentIndexForEditOperationCompleted(object arg) {
            if ((this.GetDocumentIndexForEditCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentIndexForEditCompleted(this, new GetDocumentIndexForEditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveAndReturnDocumentIndex", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveAndReturnDocumentIndex(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("SaveAndReturnDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void SaveAndReturnDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.SaveAndReturnDocumentIndexAsync(sessionTicket, xmlAxDocumentPointer, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void SaveAndReturnDocumentIndexAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.SaveAndReturnDocumentIndexOperationCompleted == null)) {
                this.SaveAndReturnDocumentIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveAndReturnDocumentIndexOperationCompleted);
            }
            this.InvokeAsync("SaveAndReturnDocumentIndex", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.SaveAndReturnDocumentIndexOperationCompleted, userState);
        }
        private void OnSaveAndReturnDocumentIndexOperationCompleted(object arg) {
            if ((this.SaveAndReturnDocumentIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveAndReturnDocumentIndexCompleted(this, new SaveAndReturnDocumentIndexCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveAndReturnDocumentIndexByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveAndReturnDocumentIndexByRef(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("SaveAndReturnDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void SaveAndReturnDocumentIndexByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS) {
            this.SaveAndReturnDocumentIndexByRefAsync(sessionTicket, docRef, xmlAxDocumentIndex, ignoreDupIndex, ignoreDLS, null);
        }
        public void SaveAndReturnDocumentIndexByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentIndex, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.SaveAndReturnDocumentIndexByRefOperationCompleted == null)) {
                this.SaveAndReturnDocumentIndexByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveAndReturnDocumentIndexByRefOperationCompleted);
            }
            this.InvokeAsync("SaveAndReturnDocumentIndexByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentIndex,
                        ignoreDupIndex,
                        ignoreDLS}, this.SaveAndReturnDocumentIndexByRefOperationCompleted, userState);
        }
        private void OnSaveAndReturnDocumentIndexByRefOperationCompleted(object arg) {
            if ((this.SaveAndReturnDocumentIndexByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveAndReturnDocumentIndexByRefCompleted(this, new SaveAndReturnDocumentIndexByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SubmitFullTextJob", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SubmitFullTextJob(string sessionTicket, string queueName, string xmlAxDocumentPointer) {
            this.Invoke("SubmitFullTextJob", new object[] {
                        sessionTicket,
                        queueName,
                        xmlAxDocumentPointer});
        }
        public void SubmitFullTextJobAsync(string sessionTicket, string queueName, string xmlAxDocumentPointer) {
            this.SubmitFullTextJobAsync(sessionTicket, queueName, xmlAxDocumentPointer, null);
        }
        public void SubmitFullTextJobAsync(string sessionTicket, string queueName, string xmlAxDocumentPointer, object userState) {
            if ((this.SubmitFullTextJobOperationCompleted == null)) {
                this.SubmitFullTextJobOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitFullTextJobOperationCompleted);
            }
            this.InvokeAsync("SubmitFullTextJob", new object[] {
                        sessionTicket,
                        queueName,
                        xmlAxDocumentPointer}, this.SubmitFullTextJobOperationCompleted, userState);
        }
        private void OnSubmitFullTextJobOperationCompleted(object arg) {
            if ((this.SubmitFullTextJobCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitFullTextJobCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SubmitFullTextJobByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SubmitFullTextJobByRef(string sessionTicket, string queueName, string docReference) {
            this.Invoke("SubmitFullTextJobByRef", new object[] {
                        sessionTicket,
                        queueName,
                        docReference});
        }
        public void SubmitFullTextJobByRefAsync(string sessionTicket, string queueName, string docReference) {
            this.SubmitFullTextJobByRefAsync(sessionTicket, queueName, docReference, null);
        }
        public void SubmitFullTextJobByRefAsync(string sessionTicket, string queueName, string docReference, object userState) {
            if ((this.SubmitFullTextJobByRefOperationCompleted == null)) {
                this.SubmitFullTextJobByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitFullTextJobByRefOperationCompleted);
            }
            this.InvokeAsync("SubmitFullTextJobByRef", new object[] {
                        sessionTicket,
                        queueName,
                        docReference}, this.SubmitFullTextJobByRefOperationCompleted, userState);
        }
        private void OnSubmitFullTextJobByRefOperationCompleted(object arg) {
            if ((this.SubmitFullTextJobByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitFullTextJobByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextJobQueueList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFullTextJobQueueList(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetFullTextJobQueueList", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetFullTextJobQueueListAsync(string sessionTicket, string dataSource) {
            this.GetFullTextJobQueueListAsync(sessionTicket, dataSource, null);
        }
        public void GetFullTextJobQueueListAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetFullTextJobQueueListOperationCompleted == null)) {
                this.GetFullTextJobQueueListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextJobQueueListOperationCompleted);
            }
            this.InvokeAsync("GetFullTextJobQueueList", new object[] {
                        sessionTicket,
                        dataSource}, this.GetFullTextJobQueueListOperationCompleted, userState);
        }
        private void OnGetFullTextJobQueueListOperationCompleted(object arg) {
            if ((this.GetFullTextJobQueueListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextJobQueueListCompleted(this, new GetFullTextJobQueueListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextJobList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFullTextJobList(string sessionTicket, string dataSource, string queueName) {
            object[] results = this.Invoke("GetFullTextJobList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName});
            return ((string)(results[0]));
        }
        public void GetFullTextJobListAsync(string sessionTicket, string dataSource, string queueName) {
            this.GetFullTextJobListAsync(sessionTicket, dataSource, queueName, null);
        }
        public void GetFullTextJobListAsync(string sessionTicket, string dataSource, string queueName, object userState) {
            if ((this.GetFullTextJobListOperationCompleted == null)) {
                this.GetFullTextJobListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextJobListOperationCompleted);
            }
            this.InvokeAsync("GetFullTextJobList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName}, this.GetFullTextJobListOperationCompleted, userState);
        }
        private void OnGetFullTextJobListOperationCompleted(object arg) {
            if ((this.GetFullTextJobListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextJobListCompleted(this, new GetFullTextJobListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextHitCount", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetFullTextHitCount(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("GetFullTextHitCount", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((int)(results[0]));
        }
        public void GetFullTextHitCountAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.GetFullTextHitCountAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void GetFullTextHitCountAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.GetFullTextHitCountOperationCompleted == null)) {
                this.GetFullTextHitCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextHitCountOperationCompleted);
            }
            this.InvokeAsync("GetFullTextHitCount", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.GetFullTextHitCountOperationCompleted, userState);
        }
        private void OnGetFullTextHitCountOperationCompleted(object arg) {
            if ((this.GetFullTextHitCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextHitCountCompleted(this, new GetFullTextHitCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextHitCountByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetFullTextHitCountByRef(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetFullTextHitCountByRef", new object[] {
                        sessionTicket,
                        docRef});
            return ((int)(results[0]));
        }
        public void GetFullTextHitCountByRefAsync(string sessionTicket, string docRef) {
            this.GetFullTextHitCountByRefAsync(sessionTicket, docRef, null);
        }
        public void GetFullTextHitCountByRefAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetFullTextHitCountByRefOperationCompleted == null)) {
                this.GetFullTextHitCountByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextHitCountByRefOperationCompleted);
            }
            this.InvokeAsync("GetFullTextHitCountByRef", new object[] {
                        sessionTicket,
                        docRef}, this.GetFullTextHitCountByRefOperationCompleted, userState);
        }
        private void OnGetFullTextHitCountByRefOperationCompleted(object arg) {
            if ((this.GetFullTextHitCountByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextHitCountByRefCompleted(this, new GetFullTextHitCountByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextHitInfo", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFullTextHitInfo(string sessionTicket, string xmlAxDocumentPointer, int hitIndex) {
            object[] results = this.Invoke("GetFullTextHitInfo", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        hitIndex});
            return ((string)(results[0]));
        }
        public void GetFullTextHitInfoAsync(string sessionTicket, string xmlAxDocumentPointer, int hitIndex) {
            this.GetFullTextHitInfoAsync(sessionTicket, xmlAxDocumentPointer, hitIndex, null);
        }
        public void GetFullTextHitInfoAsync(string sessionTicket, string xmlAxDocumentPointer, int hitIndex, object userState) {
            if ((this.GetFullTextHitInfoOperationCompleted == null)) {
                this.GetFullTextHitInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextHitInfoOperationCompleted);
            }
            this.InvokeAsync("GetFullTextHitInfo", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        hitIndex}, this.GetFullTextHitInfoOperationCompleted, userState);
        }
        private void OnGetFullTextHitInfoOperationCompleted(object arg) {
            if ((this.GetFullTextHitInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextHitInfoCompleted(this, new GetFullTextHitInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFullTextHitInfoByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFullTextHitInfoByRef(string sessionTicket, string docReference, int hitIndex) {
            object[] results = this.Invoke("GetFullTextHitInfoByRef", new object[] {
                        sessionTicket,
                        docReference,
                        hitIndex});
            return ((string)(results[0]));
        }
        public void GetFullTextHitInfoByRefAsync(string sessionTicket, string docReference, int hitIndex) {
            this.GetFullTextHitInfoByRefAsync(sessionTicket, docReference, hitIndex, null);
        }
        public void GetFullTextHitInfoByRefAsync(string sessionTicket, string docReference, int hitIndex, object userState) {
            if ((this.GetFullTextHitInfoByRefOperationCompleted == null)) {
                this.GetFullTextHitInfoByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFullTextHitInfoByRefOperationCompleted);
            }
            this.InvokeAsync("GetFullTextHitInfoByRef", new object[] {
                        sessionTicket,
                        docReference,
                        hitIndex}, this.GetFullTextHitInfoByRefOperationCompleted, userState);
        }
        private void OnGetFullTextHitInfoByRefOperationCompleted(object arg) {
            if ((this.GetFullTextHitInfoByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFullTextHitInfoByRefCompleted(this, new GetFullTextHitInfoByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/OpenBatchDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OpenBatchDocumentByRef(string sessionTicket, string docReference, int mode) {
            object[] results = this.Invoke("OpenBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        mode});
            return ((string)(results[0]));
        }
        public void OpenBatchDocumentByRefAsync(string sessionTicket, string docReference, int mode) {
            this.OpenBatchDocumentByRefAsync(sessionTicket, docReference, mode, null);
        }
        public void OpenBatchDocumentByRefAsync(string sessionTicket, string docReference, int mode, object userState) {
            if ((this.OpenBatchDocumentByRefOperationCompleted == null)) {
                this.OpenBatchDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOpenBatchDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("OpenBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        mode}, this.OpenBatchDocumentByRefOperationCompleted, userState);
        }
        private void OnOpenBatchDocumentByRefOperationCompleted(object arg) {
            if ((this.OpenBatchDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OpenBatchDocumentByRefCompleted(this, new OpenBatchDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CloseBatchDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CloseBatchDocumentByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("CloseBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void CloseBatchDocumentByRefAsync(string sessionTicket, string docReference) {
            this.CloseBatchDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void CloseBatchDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.CloseBatchDocumentByRefOperationCompleted == null)) {
                this.CloseBatchDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCloseBatchDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("CloseBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.CloseBatchDocumentByRefOperationCompleted, userState);
        }
        private void OnCloseBatchDocumentByRefOperationCompleted(object arg) {
            if ((this.CloseBatchDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CloseBatchDocumentByRefCompleted(this, new CloseBatchDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LockBatchDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LockBatchDocumentByRef(string sessionTicket, string docReference, int mode) {
            object[] results = this.Invoke("LockBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        mode});
            return ((string)(results[0]));
        }
        public void LockBatchDocumentByRefAsync(string sessionTicket, string docReference, int mode) {
            this.LockBatchDocumentByRefAsync(sessionTicket, docReference, mode, null);
        }
        public void LockBatchDocumentByRefAsync(string sessionTicket, string docReference, int mode, object userState) {
            if ((this.LockBatchDocumentByRefOperationCompleted == null)) {
                this.LockBatchDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLockBatchDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("LockBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        mode}, this.LockBatchDocumentByRefOperationCompleted, userState);
        }
        private void OnLockBatchDocumentByRefOperationCompleted(object arg) {
            if ((this.LockBatchDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LockBatchDocumentByRefCompleted(this, new LockBatchDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UnlockBatchDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UnlockBatchDocument(string sessionTicket, string docReference) {
            object[] results = this.Invoke("UnlockBatchDocument", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void UnlockBatchDocumentAsync(string sessionTicket, string docReference) {
            this.UnlockBatchDocumentAsync(sessionTicket, docReference, null);
        }
        public void UnlockBatchDocumentAsync(string sessionTicket, string docReference, object userState) {
            if ((this.UnlockBatchDocumentOperationCompleted == null)) {
                this.UnlockBatchDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUnlockBatchDocumentOperationCompleted);
            }
            this.InvokeAsync("UnlockBatchDocument", new object[] {
                        sessionTicket,
                        docReference}, this.UnlockBatchDocumentOperationCompleted, userState);
        }
        private void OnUnlockBatchDocumentOperationCompleted(object arg) {
            if ((this.UnlockBatchDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UnlockBatchDocumentCompleted(this, new UnlockBatchDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UnlockBatchDocuments", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UnlockBatchDocuments(string sessionTicket, string dataSource, string xmlAxStringArray) {
            this.Invoke("UnlockBatchDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStringArray});
        }
        public void UnlockBatchDocumentsAsync(string sessionTicket, string dataSource, string xmlAxStringArray) {
            this.UnlockBatchDocumentsAsync(sessionTicket, dataSource, xmlAxStringArray, null);
        }
        public void UnlockBatchDocumentsAsync(string sessionTicket, string dataSource, string xmlAxStringArray, object userState) {
            if ((this.UnlockBatchDocumentsOperationCompleted == null)) {
                this.UnlockBatchDocumentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUnlockBatchDocumentsOperationCompleted);
            }
            this.InvokeAsync("UnlockBatchDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStringArray}, this.UnlockBatchDocumentsOperationCompleted, userState);
        }
        private void OnUnlockBatchDocumentsOperationCompleted(object arg) {
            if ((this.UnlockBatchDocumentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UnlockBatchDocumentsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetBatchDocumentListByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBatchDocumentListByAppId(string sessionTicket, string dataSource, short appId) {
            object[] results = this.Invoke("GetBatchDocumentListByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId});
            return ((string)(results[0]));
        }
        public void GetBatchDocumentListByAppIdAsync(string sessionTicket, string dataSource, short appId) {
            this.GetBatchDocumentListByAppIdAsync(sessionTicket, dataSource, appId, null);
        }
        public void GetBatchDocumentListByAppIdAsync(string sessionTicket, string dataSource, short appId, object userState) {
            if ((this.GetBatchDocumentListByAppIdOperationCompleted == null)) {
                this.GetBatchDocumentListByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBatchDocumentListByAppIdOperationCompleted);
            }
            this.InvokeAsync("GetBatchDocumentListByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId}, this.GetBatchDocumentListByAppIdOperationCompleted, userState);
        }
        private void OnGetBatchDocumentListByAppIdOperationCompleted(object arg) {
            if ((this.GetBatchDocumentListByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBatchDocumentListByAppIdCompleted(this, new GetBatchDocumentListByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetBatchDocumentListByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBatchDocumentListByAppName(string sessionTicket, string dataSource, string appName) {
            object[] results = this.Invoke("GetBatchDocumentListByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName});
            return ((string)(results[0]));
        }
        public void GetBatchDocumentListByAppNameAsync(string sessionTicket, string dataSource, string appName) {
            this.GetBatchDocumentListByAppNameAsync(sessionTicket, dataSource, appName, null);
        }
        public void GetBatchDocumentListByAppNameAsync(string sessionTicket, string dataSource, string appName, object userState) {
            if ((this.GetBatchDocumentListByAppNameOperationCompleted == null)) {
                this.GetBatchDocumentListByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBatchDocumentListByAppNameOperationCompleted);
            }
            this.InvokeAsync("GetBatchDocumentListByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName}, this.GetBatchDocumentListByAppNameOperationCompleted, userState);
        }
        private void OnGetBatchDocumentListByAppNameOperationCompleted(object arg) {
            if ((this.GetBatchDocumentListByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBatchDocumentListByAppNameCompleted(this, new GetBatchDocumentListByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteBatchDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteBatchDocumentByRef(string sessionTicket, string docReference) {
            this.Invoke("DeleteBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
        }
        public void DeleteBatchDocumentByRefAsync(string sessionTicket, string docReference) {
            this.DeleteBatchDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void DeleteBatchDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.DeleteBatchDocumentByRefOperationCompleted == null)) {
                this.DeleteBatchDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteBatchDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteBatchDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.DeleteBatchDocumentByRefOperationCompleted, userState);
        }
        private void OnDeleteBatchDocumentByRefOperationCompleted(object arg) {
            if ((this.DeleteBatchDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteBatchDocumentByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteBatchDocumentsByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteBatchDocumentsByRef(string sessionTicket, string dataSource, string xmlAxStringArray) {
            object[] results = this.Invoke("DeleteBatchDocumentsByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStringArray});
            return ((string)(results[0]));
        }
        public void DeleteBatchDocumentsByRefAsync(string sessionTicket, string dataSource, string xmlAxStringArray) {
            this.DeleteBatchDocumentsByRefAsync(sessionTicket, dataSource, xmlAxStringArray, null);
        }
        public void DeleteBatchDocumentsByRefAsync(string sessionTicket, string dataSource, string xmlAxStringArray, object userState) {
            if ((this.DeleteBatchDocumentsByRefOperationCompleted == null)) {
                this.DeleteBatchDocumentsByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteBatchDocumentsByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteBatchDocumentsByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStringArray}, this.DeleteBatchDocumentsByRefOperationCompleted, userState);
        }
        private void OnDeleteBatchDocumentsByRefOperationCompleted(object arg) {
            if ((this.DeleteBatchDocumentsByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteBatchDocumentsByRefCompleted(this, new DeleteBatchDocumentsByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ChangeBatchNameByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangeBatchNameByRef(string sessionTicket, string docReference, string newName) {
            this.Invoke("ChangeBatchNameByRef", new object[] {
                        sessionTicket,
                        docReference,
                        newName});
        }
        public void ChangeBatchNameByRefAsync(string sessionTicket, string docReference, string newName) {
            this.ChangeBatchNameByRefAsync(sessionTicket, docReference, newName, null);
        }
        public void ChangeBatchNameByRefAsync(string sessionTicket, string docReference, string newName, object userState) {
            if ((this.ChangeBatchNameByRefOperationCompleted == null)) {
                this.ChangeBatchNameByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeBatchNameByRefOperationCompleted);
            }
            this.InvokeAsync("ChangeBatchNameByRef", new object[] {
                        sessionTicket,
                        docReference,
                        newName}, this.ChangeBatchNameByRefOperationCompleted, userState);
        }
        private void OnChangeBatchNameByRefOperationCompleted(object arg) {
            if ((this.ChangeBatchNameByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeBatchNameByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ChangeBatchMemoByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangeBatchMemoByRef(string sessionTicket, string docReference, string newMemo) {
            this.Invoke("ChangeBatchMemoByRef", new object[] {
                        sessionTicket,
                        docReference,
                        newMemo});
        }
        public void ChangeBatchMemoByRefAsync(string sessionTicket, string docReference, string newMemo) {
            this.ChangeBatchMemoByRefAsync(sessionTicket, docReference, newMemo, null);
        }
        public void ChangeBatchMemoByRefAsync(string sessionTicket, string docReference, string newMemo, object userState) {
            if ((this.ChangeBatchMemoByRefOperationCompleted == null)) {
                this.ChangeBatchMemoByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeBatchMemoByRefOperationCompleted);
            }
            this.InvokeAsync("ChangeBatchMemoByRef", new object[] {
                        sessionTicket,
                        docReference,
                        newMemo}, this.ChangeBatchMemoByRefOperationCompleted, userState);
        }
        private void OnChangeBatchMemoByRefOperationCompleted(object arg) {
            if ((this.ChangeBatchMemoByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeBatchMemoByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetBatchMemoByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBatchMemoByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("GetBatchMemoByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void GetBatchMemoByRefAsync(string sessionTicket, string docReference) {
            this.GetBatchMemoByRefAsync(sessionTicket, docReference, null);
        }
        public void GetBatchMemoByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.GetBatchMemoByRefOperationCompleted == null)) {
                this.GetBatchMemoByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBatchMemoByRefOperationCompleted);
            }
            this.InvokeAsync("GetBatchMemoByRef", new object[] {
                        sessionTicket,
                        docReference}, this.GetBatchMemoByRefOperationCompleted, userState);
        }
        private void OnGetBatchMemoByRefOperationCompleted(object arg) {
            if ((this.GetBatchMemoByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBatchMemoByRefCompleted(this, new GetBatchMemoByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CreateDocumentFromBatchPageByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateDocumentFromBatchPageByRef(string sessionTicket, string xmlDocumentIndex, string pageReference, bool ignoreDupIndex, bool ignoreDLS) {
            object[] results = this.Invoke("CreateDocumentFromBatchPageByRef", new object[] {
                        sessionTicket,
                        xmlDocumentIndex,
                        pageReference,
                        ignoreDupIndex,
                        ignoreDLS});
            return ((string)(results[0]));
        }
        public void CreateDocumentFromBatchPageByRefAsync(string sessionTicket, string xmlDocumentIndex, string pageReference, bool ignoreDupIndex, bool ignoreDLS) {
            this.CreateDocumentFromBatchPageByRefAsync(sessionTicket, xmlDocumentIndex, pageReference, ignoreDupIndex, ignoreDLS, null);
        }
        public void CreateDocumentFromBatchPageByRefAsync(string sessionTicket, string xmlDocumentIndex, string pageReference, bool ignoreDupIndex, bool ignoreDLS, object userState) {
            if ((this.CreateDocumentFromBatchPageByRefOperationCompleted == null)) {
                this.CreateDocumentFromBatchPageByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateDocumentFromBatchPageByRefOperationCompleted);
            }
            this.InvokeAsync("CreateDocumentFromBatchPageByRef", new object[] {
                        sessionTicket,
                        xmlDocumentIndex,
                        pageReference,
                        ignoreDupIndex,
                        ignoreDLS}, this.CreateDocumentFromBatchPageByRefOperationCompleted, userState);
        }
        private void OnCreateDocumentFromBatchPageByRefOperationCompleted(object arg) {
            if ((this.CreateDocumentFromBatchPageByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateDocumentFromBatchPageByRefCompleted(this, new CreateDocumentFromBatchPageByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/AttachBatchPagesByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AttachBatchPagesByRef(string sessionTicket, string docReference, string batchReference, int batchPage, int batchPageCount) {
            object[] results = this.Invoke("AttachBatchPagesByRef", new object[] {
                        sessionTicket,
                        docReference,
                        batchReference,
                        batchPage,
                        batchPageCount});
            return ((string)(results[0]));
        }
        public void AttachBatchPagesByRefAsync(string sessionTicket, string docReference, string batchReference, int batchPage, int batchPageCount) {
            this.AttachBatchPagesByRefAsync(sessionTicket, docReference, batchReference, batchPage, batchPageCount, null);
        }
        public void AttachBatchPagesByRefAsync(string sessionTicket, string docReference, string batchReference, int batchPage, int batchPageCount, object userState) {
            if ((this.AttachBatchPagesByRefOperationCompleted == null)) {
                this.AttachBatchPagesByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAttachBatchPagesByRefOperationCompleted);
            }
            this.InvokeAsync("AttachBatchPagesByRef", new object[] {
                        sessionTicket,
                        docReference,
                        batchReference,
                        batchPage,
                        batchPageCount}, this.AttachBatchPagesByRefOperationCompleted, userState);
        }
        private void OnAttachBatchPagesByRefOperationCompleted(object arg) {
            if ((this.AttachBatchPagesByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AttachBatchPagesByRefCompleted(this, new AttachBatchPagesByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CreateBatchPage", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateBatchPage(string sessionTicket, string dataSource, short appId, string batchName, string xmlPageUploadData) {
            object[] results = this.Invoke("CreateBatchPage", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        batchName,
                        xmlPageUploadData});
            return ((string)(results[0]));
        }
        public void CreateBatchPageAsync(string sessionTicket, string dataSource, short appId, string batchName, string xmlPageUploadData) {
            this.CreateBatchPageAsync(sessionTicket, dataSource, appId, batchName, xmlPageUploadData, null);
        }
        public void CreateBatchPageAsync(string sessionTicket, string dataSource, short appId, string batchName, string xmlPageUploadData, object userState) {
            if ((this.CreateBatchPageOperationCompleted == null)) {
                this.CreateBatchPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateBatchPageOperationCompleted);
            }
            this.InvokeAsync("CreateBatchPage", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        batchName,
                        xmlPageUploadData}, this.CreateBatchPageOperationCompleted, userState);
        }
        private void OnCreateBatchPageOperationCompleted(object arg) {
            if ((this.CreateBatchPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateBatchPageCompleted(this, new CreateBatchPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CreateBatchPageByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateBatchPageByRef(string sessionTicket, string docReference, string xmlPageUploadData) {
            object[] results = this.Invoke("CreateBatchPageByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlPageUploadData});
            return ((string)(results[0]));
        }
        public void CreateBatchPageByRefAsync(string sessionTicket, string docReference, string xmlPageUploadData) {
            this.CreateBatchPageByRefAsync(sessionTicket, docReference, xmlPageUploadData, null);
        }
        public void CreateBatchPageByRefAsync(string sessionTicket, string docReference, string xmlPageUploadData, object userState) {
            if ((this.CreateBatchPageByRefOperationCompleted == null)) {
                this.CreateBatchPageByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateBatchPageByRefOperationCompleted);
            }
            this.InvokeAsync("CreateBatchPageByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlPageUploadData}, this.CreateBatchPageByRefOperationCompleted, userState);
        }
        private void OnCreateBatchPageByRefOperationCompleted(object arg) {
            if ((this.CreateBatchPageByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateBatchPageByRefCompleted(this, new CreateBatchPageByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetBatchPageListByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetBatchPageListByRef(string sessionTicket, string docReference, int startPosition, int pageCount) {
            object[] results = this.Invoke("GetBatchPageListByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageCount});
            return ((string)(results[0]));
        }
        public void GetBatchPageListByRefAsync(string sessionTicket, string docReference, int startPosition, int pageCount) {
            this.GetBatchPageListByRefAsync(sessionTicket, docReference, startPosition, pageCount, null);
        }
        public void GetBatchPageListByRefAsync(string sessionTicket, string docReference, int startPosition, int pageCount, object userState) {
            if ((this.GetBatchPageListByRefOperationCompleted == null)) {
                this.GetBatchPageListByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBatchPageListByRefOperationCompleted);
            }
            this.InvokeAsync("GetBatchPageListByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageCount}, this.GetBatchPageListByRefOperationCompleted, userState);
        }
        private void OnGetBatchPageListByRefOperationCompleted(object arg) {
            if ((this.GetBatchPageListByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBatchPageListByRefCompleted(this, new GetBatchPageListByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteBatchPages", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteBatchPages(string sessionTicket, string batchReference, int batchPage, int batchPageCount) {
            object[] results = this.Invoke("DeleteBatchPages", new object[] {
                        sessionTicket,
                        batchReference,
                        batchPage,
                        batchPageCount});
            return ((string)(results[0]));
        }
        public void DeleteBatchPagesAsync(string sessionTicket, string batchReference, int batchPage, int batchPageCount) {
            this.DeleteBatchPagesAsync(sessionTicket, batchReference, batchPage, batchPageCount, null);
        }
        public void DeleteBatchPagesAsync(string sessionTicket, string batchReference, int batchPage, int batchPageCount, object userState) {
            if ((this.DeleteBatchPagesOperationCompleted == null)) {
                this.DeleteBatchPagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteBatchPagesOperationCompleted);
            }
            this.InvokeAsync("DeleteBatchPages", new object[] {
                        sessionTicket,
                        batchReference,
                        batchPage,
                        batchPageCount}, this.DeleteBatchPagesOperationCompleted, userState);
        }
        private void OnDeleteBatchPagesOperationCompleted(object arg) {
            if ((this.DeleteBatchPagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteBatchPagesCompleted(this, new DeleteBatchPagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DownloadImageStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DownloadImageStream(string sessionTicket, string dataSource, string sourceFile, string xmlStreamData) {
            object[] results = this.Invoke("DownloadImageStream", new object[] {
                        sessionTicket,
                        dataSource,
                        sourceFile,
                        xmlStreamData});
            return ((string)(results[0]));
        }
        public void DownloadImageStreamAsync(string sessionTicket, string dataSource, string sourceFile, string xmlStreamData) {
            this.DownloadImageStreamAsync(sessionTicket, dataSource, sourceFile, xmlStreamData, null);
        }
        public void DownloadImageStreamAsync(string sessionTicket, string dataSource, string sourceFile, string xmlStreamData, object userState) {
            if ((this.DownloadImageStreamOperationCompleted == null)) {
                this.DownloadImageStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDownloadImageStreamOperationCompleted);
            }
            this.InvokeAsync("DownloadImageStream", new object[] {
                        sessionTicket,
                        dataSource,
                        sourceFile,
                        xmlStreamData}, this.DownloadImageStreamOperationCompleted, userState);
        }
        private void OnDownloadImageStreamOperationCompleted(object arg) {
            if ((this.DownloadImageStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DownloadImageStreamCompleted(this, new DownloadImageStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UploadImageStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UploadImageStream(string sessionTicket, string dataSource, string xmlAxStreamData) {
            object[] results = this.Invoke("UploadImageStream", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStreamData});
            return ((string)(results[0]));
        }
        public void UploadImageStreamAsync(string sessionTicket, string dataSource, string xmlAxStreamData) {
            this.UploadImageStreamAsync(sessionTicket, dataSource, xmlAxStreamData, null);
        }
        public void UploadImageStreamAsync(string sessionTicket, string dataSource, string xmlAxStreamData, object userState) {
            if ((this.UploadImageStreamOperationCompleted == null)) {
                this.UploadImageStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadImageStreamOperationCompleted);
            }
            this.InvokeAsync("UploadImageStream", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxStreamData}, this.UploadImageStreamOperationCompleted, userState);
        }
        private void OnUploadImageStreamOperationCompleted(object arg) {
            if ((this.UploadImageStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadImageStreamCompleted(this, new UploadImageStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetJobQueueList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetJobQueueList(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetJobQueueList", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetJobQueueListAsync(string sessionTicket, string dataSource) {
            this.GetJobQueueListAsync(sessionTicket, dataSource, null);
        }
        public void GetJobQueueListAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetJobQueueListOperationCompleted == null)) {
                this.GetJobQueueListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJobQueueListOperationCompleted);
            }
            this.InvokeAsync("GetJobQueueList", new object[] {
                        sessionTicket,
                        dataSource}, this.GetJobQueueListOperationCompleted, userState);
        }
        private void OnGetJobQueueListOperationCompleted(object arg) {
            if ((this.GetJobQueueListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJobQueueListCompleted(this, new GetJobQueueListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetJobList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetJobList(string sessionTicket, string dataSource, string queueName) {
            object[] results = this.Invoke("GetJobList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName});
            return ((string)(results[0]));
        }
        public void GetJobListAsync(string sessionTicket, string dataSource, string queueName) {
            this.GetJobListAsync(sessionTicket, dataSource, queueName, null);
        }
        public void GetJobListAsync(string sessionTicket, string dataSource, string queueName, object userState) {
            if ((this.GetJobListOperationCompleted == null)) {
                this.GetJobListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJobListOperationCompleted);
            }
            this.InvokeAsync("GetJobList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName}, this.GetJobListOperationCompleted, userState);
        }
        private void OnGetJobListOperationCompleted(object arg) {
            if ((this.GetJobListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJobListCompleted(this, new GetJobListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetJobElementList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetJobElementList(string sessionTicket, string dataSource, string queueName, int jobId) {
            object[] results = this.Invoke("GetJobElementList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobId});
            return ((string)(results[0]));
        }
        public void GetJobElementListAsync(string sessionTicket, string dataSource, string queueName, int jobId) {
            this.GetJobElementListAsync(sessionTicket, dataSource, queueName, jobId, null);
        }
        public void GetJobElementListAsync(string sessionTicket, string dataSource, string queueName, int jobId, object userState) {
            if ((this.GetJobElementListOperationCompleted == null)) {
                this.GetJobElementListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetJobElementListOperationCompleted);
            }
            this.InvokeAsync("GetJobElementList", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobId}, this.GetJobElementListOperationCompleted, userState);
        }
        private void OnGetJobElementListOperationCompleted(object arg) {
            if ((this.GetJobElementListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetJobElementListCompleted(this, new GetJobElementListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ResubmitJobs", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ResubmitJobs(string sessionTicket, string dataSource, string queueName, int[] jobIds) {
            this.Invoke("ResubmitJobs", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobIds});
        }
        public void ResubmitJobsAsync(string sessionTicket, string dataSource, string queueName, int[] jobIds) {
            this.ResubmitJobsAsync(sessionTicket, dataSource, queueName, jobIds, null);
        }
        public void ResubmitJobsAsync(string sessionTicket, string dataSource, string queueName, int[] jobIds, object userState) {
            if ((this.ResubmitJobsOperationCompleted == null)) {
                this.ResubmitJobsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnResubmitJobsOperationCompleted);
            }
            this.InvokeAsync("ResubmitJobs", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobIds}, this.ResubmitJobsOperationCompleted, userState);
        }
        private void OnResubmitJobsOperationCompleted(object arg) {
            if ((this.ResubmitJobsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ResubmitJobsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteJobs", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteJobs(string sessionTicket, string dataSource, string queueName, int[] jobIds) {
            this.Invoke("DeleteJobs", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobIds});
        }
        public void DeleteJobsAsync(string sessionTicket, string dataSource, string queueName, int[] jobIds) {
            this.DeleteJobsAsync(sessionTicket, dataSource, queueName, jobIds, null);
        }
        public void DeleteJobsAsync(string sessionTicket, string dataSource, string queueName, int[] jobIds, object userState) {
            if ((this.DeleteJobsOperationCompleted == null)) {
                this.DeleteJobsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteJobsOperationCompleted);
            }
            this.InvokeAsync("DeleteJobs", new object[] {
                        sessionTicket,
                        dataSource,
                        queueName,
                        jobIds}, this.DeleteJobsOperationCompleted, userState);
        }
        private void OnDeleteJobsOperationCompleted(object arg) {
            if ((this.DeleteJobsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteJobsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFAMJobStatus", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public short GetFAMJobStatus(string sessionTicket, string dataSource, string jobString) {
            object[] results = this.Invoke("GetFAMJobStatus", new object[] {
                        sessionTicket,
                        dataSource,
                        jobString});
            return ((short)(results[0]));
        }
        public void GetFAMJobStatusAsync(string sessionTicket, string dataSource, string jobString) {
            this.GetFAMJobStatusAsync(sessionTicket, dataSource, jobString, null);
        }
        public void GetFAMJobStatusAsync(string sessionTicket, string dataSource, string jobString, object userState) {
            if ((this.GetFAMJobStatusOperationCompleted == null)) {
                this.GetFAMJobStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFAMJobStatusOperationCompleted);
            }
            this.InvokeAsync("GetFAMJobStatus", new object[] {
                        sessionTicket,
                        dataSource,
                        jobString}, this.GetFAMJobStatusOperationCompleted, userState);
        }
        private void OnGetFAMJobStatusOperationCompleted(object arg) {
            if ((this.GetFAMJobStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFAMJobStatusCompleted(this, new GetFAMJobStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFAMJobErrorMsg", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFAMJobErrorMsg(string sessionTicket, string datasource, string jobString) {
            object[] results = this.Invoke("GetFAMJobErrorMsg", new object[] {
                        sessionTicket,
                        datasource,
                        jobString});
            return ((string)(results[0]));
        }
        public void GetFAMJobErrorMsgAsync(string sessionTicket, string datasource, string jobString) {
            this.GetFAMJobErrorMsgAsync(sessionTicket, datasource, jobString, null);
        }
        public void GetFAMJobErrorMsgAsync(string sessionTicket, string datasource, string jobString, object userState) {
            if ((this.GetFAMJobErrorMsgOperationCompleted == null)) {
                this.GetFAMJobErrorMsgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFAMJobErrorMsgOperationCompleted);
            }
            this.InvokeAsync("GetFAMJobErrorMsg", new object[] {
                        sessionTicket,
                        datasource,
                        jobString}, this.GetFAMJobErrorMsgOperationCompleted, userState);
        }
        private void OnGetFAMJobErrorMsgOperationCompleted(object arg) {
            if ((this.GetFAMJobErrorMsgCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFAMJobErrorMsgCompleted(this, new GetFAMJobErrorMsgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LogAuditEvent", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogAuditEvent(string sessionTicket, string docRef, string eventDescription, string hippaDescription) {
            this.Invoke("LogAuditEvent", new object[] {
                        sessionTicket,
                        docRef,
                        eventDescription,
                        hippaDescription});
        }
        public void LogAuditEventAsync(string sessionTicket, string docRef, string eventDescription, string hippaDescription) {
            this.LogAuditEventAsync(sessionTicket, docRef, eventDescription, hippaDescription, null);
        }
        public void LogAuditEventAsync(string sessionTicket, string docRef, string eventDescription, string hippaDescription, object userState) {
            if ((this.LogAuditEventOperationCompleted == null)) {
                this.LogAuditEventOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogAuditEventOperationCompleted);
            }
            this.InvokeAsync("LogAuditEvent", new object[] {
                        sessionTicket,
                        docRef,
                        eventDescription,
                        hippaDescription}, this.LogAuditEventOperationCompleted, userState);
        }
        private void OnLogAuditEventOperationCompleted(object arg) {
            if ((this.LogAuditEventCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogAuditEventCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetHookMessage", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetHookMessage(string sessionTicket, string dataSource, bool clearAll) {
            object[] results = this.Invoke("GetHookMessage", new object[] {
                        sessionTicket,
                        dataSource,
                        clearAll});
            return ((string)(results[0]));
        }
        public void GetHookMessageAsync(string sessionTicket, string dataSource, bool clearAll) {
            this.GetHookMessageAsync(sessionTicket, dataSource, clearAll, null);
        }
        public void GetHookMessageAsync(string sessionTicket, string dataSource, bool clearAll, object userState) {
            if ((this.GetHookMessageOperationCompleted == null)) {
                this.GetHookMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHookMessageOperationCompleted);
            }
            this.InvokeAsync("GetHookMessage", new object[] {
                        sessionTicket,
                        dataSource,
                        clearAll}, this.GetHookMessageOperationCompleted, userState);
        }
        private void OnGetHookMessageOperationCompleted(object arg) {
            if ((this.GetHookMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetHookMessageCompleted(this, new GetHookMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/Login", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Login(string sessionTicket, string dataSource, string userId, string password, int features) {
            object[] results = this.Invoke("Login", new object[] {
                        sessionTicket,
                        dataSource,
                        userId,
                        password,
                        features});
            return ((string)(results[0]));
        }
        public void LoginAsync(string sessionTicket, string dataSource, string userId, string password, int features) {
            this.LoginAsync(sessionTicket, dataSource, userId, password, features, null);
        }
        public void LoginAsync(string sessionTicket, string dataSource, string userId, string password, int features, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        sessionTicket,
                        dataSource,
                        userId,
                        password,
                        features}, this.LoginOperationCompleted, userState);
        }
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxWinCodeValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SecuredLogin", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SecuredLogin(string sessionTicket, string dataSource, string userId, string keyId, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] credentials, int features) {
            object[] results = this.Invoke("SecuredLogin", new object[] {
                        sessionTicket,
                        dataSource,
                        userId,
                        keyId,
                        credentials,
                        features});
            return ((string)(results[0]));
        }
        public void SecuredLoginAsync(string sessionTicket, string dataSource, string userId, string keyId, byte[] credentials, int features) {
            this.SecuredLoginAsync(sessionTicket, dataSource, userId, keyId, credentials, features, null);
        }
        public void SecuredLoginAsync(string sessionTicket, string dataSource, string userId, string keyId, byte[] credentials, int features, object userState) {
            if ((this.SecuredLoginOperationCompleted == null)) {
                this.SecuredLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSecuredLoginOperationCompleted);
            }
            this.InvokeAsync("SecuredLogin", new object[] {
                        sessionTicket,
                        dataSource,
                        userId,
                        keyId,
                        credentials,
                        features}, this.SecuredLoginOperationCompleted, userState);
        }
        private void OnSecuredLoginOperationCompleted(object arg) {
            if ((this.SecuredLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SecuredLoginCompleted(this, new SecuredLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxWinCodeValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/WindowsLogin", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WindowsLogin(string sessionTicket, string dataSource, int features) {
            object[] results = this.Invoke("WindowsLogin", new object[] {
                        sessionTicket,
                        dataSource,
                        features});
            return ((string)(results[0]));
        }
        public void WindowsLoginAsync(string sessionTicket, string dataSource, int features) {
            this.WindowsLoginAsync(sessionTicket, dataSource, features, null);
        }
        public void WindowsLoginAsync(string sessionTicket, string dataSource, int features, object userState) {
            if ((this.WindowsLoginOperationCompleted == null)) {
                this.WindowsLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWindowsLoginOperationCompleted);
            }
            this.InvokeAsync("WindowsLogin", new object[] {
                        sessionTicket,
                        dataSource,
                        features}, this.WindowsLoginOperationCompleted, userState);
        }
        private void OnWindowsLoginOperationCompleted(object arg) {
            if ((this.WindowsLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WindowsLoginCompleted(this, new WindowsLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LoginSet", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LoginSet(string sessionTicket, string xmlLoginDataSet, int features) {
            object[] results = this.Invoke("LoginSet", new object[] {
                        sessionTicket,
                        xmlLoginDataSet,
                        features});
            return ((string)(results[0]));
        }
        public void LoginSetAsync(string sessionTicket, string xmlLoginDataSet, int features) {
            this.LoginSetAsync(sessionTicket, xmlLoginDataSet, features, null);
        }
        public void LoginSetAsync(string sessionTicket, string xmlLoginDataSet, int features, object userState) {
            if ((this.LoginSetOperationCompleted == null)) {
                this.LoginSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginSetOperationCompleted);
            }
            this.InvokeAsync("LoginSet", new object[] {
                        sessionTicket,
                        xmlLoginDataSet,
                        features}, this.LoginSetOperationCompleted, userState);
        }
        private void OnLoginSetOperationCompleted(object arg) {
            if ((this.LoginSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginSetCompleted(this, new LoginSetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/Logout", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Logout(string sessionTicket) {
            this.Invoke("Logout", new object[] {
                        sessionTicket});
        }
        public void LogoutAsync(string sessionTicket) {
            this.LogoutAsync(sessionTicket, null);
        }
        public void LogoutAsync(string sessionTicket, object userState) {
            if ((this.LogoutOperationCompleted == null)) {
                this.LogoutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogoutOperationCompleted);
            }
            this.InvokeAsync("Logout", new object[] {
                        sessionTicket}, this.LogoutOperationCompleted, userState);
        }
        private void OnLogoutOperationCompleted(object arg) {
            if ((this.LogoutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogoutCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetEncryptionKey", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("keyId")]
        public string GetEncryptionKey(string providerId, out string key) {
            object[] results = this.Invoke("GetEncryptionKey", new object[] {
                        providerId});
            key = ((string)(results[1]));
            return ((string)(results[0]));
        }
        public void GetEncryptionKeyAsync(string providerId) {
            this.GetEncryptionKeyAsync(providerId, null);
        }
        public void GetEncryptionKeyAsync(string providerId, object userState) {
            if ((this.GetEncryptionKeyOperationCompleted == null)) {
                this.GetEncryptionKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEncryptionKeyOperationCompleted);
            }
            this.InvokeAsync("GetEncryptionKey", new object[] {
                        providerId}, this.GetEncryptionKeyOperationCompleted, userState);
        }
        private void OnGetEncryptionKeyOperationCompleted(object arg) {
            if ((this.GetEncryptionKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEncryptionKeyCompleted(this, new GetEncryptionKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryUserSessions", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryUserSessions(string sessionTicket, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryUserSessions", new object[] {
                        sessionTicket,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryUserSessionsAsync(string sessionTicket, int startPosition, int pageSize, int maxHits) {
            this.QueryUserSessionsAsync(sessionTicket, startPosition, pageSize, maxHits, null);
        }
        public void QueryUserSessionsAsync(string sessionTicket, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryUserSessionsOperationCompleted == null)) {
                this.QueryUserSessionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryUserSessionsOperationCompleted);
            }
            this.InvokeAsync("QueryUserSessions", new object[] {
                        sessionTicket,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryUserSessionsOperationCompleted, userState);
        }
        private void OnQueryUserSessionsOperationCompleted(object arg) {
            if ((this.QueryUserSessionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryUserSessionsCompleted(this, new QueryUserSessionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseUserSessionResults", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseUserSessionResults(string sessionTicket, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseUserSessionResults", new object[] {
                        sessionTicket,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseUserSessionResultsAsync(string sessionTicket, int startPosition, int pageSize) {
            this.BrowseUserSessionResultsAsync(sessionTicket, startPosition, pageSize, null);
        }
        public void BrowseUserSessionResultsAsync(string sessionTicket, int startPosition, int pageSize, object userState) {
            if ((this.BrowseUserSessionResultsOperationCompleted == null)) {
                this.BrowseUserSessionResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseUserSessionResultsOperationCompleted);
            }
            this.InvokeAsync("BrowseUserSessionResults", new object[] {
                        sessionTicket,
                        startPosition,
                        pageSize}, this.BrowseUserSessionResultsOperationCompleted, userState);
        }
        private void OnBrowseUserSessionResultsOperationCompleted(object arg) {
            if ((this.BrowseUserSessionResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseUserSessionResultsCompleted(this, new BrowseUserSessionResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/KillUserSessions", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void KillUserSessions(string sessionTicket, string xmlSessionIds) {
            this.Invoke("KillUserSessions", new object[] {
                        sessionTicket,
                        xmlSessionIds});
        }
        public void KillUserSessionsAsync(string sessionTicket, string xmlSessionIds) {
            this.KillUserSessionsAsync(sessionTicket, xmlSessionIds, null);
        }
        public void KillUserSessionsAsync(string sessionTicket, string xmlSessionIds, object userState) {
            if ((this.KillUserSessionsOperationCompleted == null)) {
                this.KillUserSessionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKillUserSessionsOperationCompleted);
            }
            this.InvokeAsync("KillUserSessions", new object[] {
                        sessionTicket,
                        xmlSessionIds}, this.KillUserSessionsOperationCompleted, userState);
        }
        private void OnKillUserSessionsOperationCompleted(object arg) {
            if ((this.KillUserSessionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.KillUserSessionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDataSourceNameList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDataSourceNameList() {
            object[] results = this.Invoke("GetDataSourceNameList", new object[0]);
            return ((string)(results[0]));
        }
        public void GetDataSourceNameListAsync() {
            this.GetDataSourceNameListAsync(null);
        }
        public void GetDataSourceNameListAsync(object userState) {
            if ((this.GetDataSourceNameListOperationCompleted == null)) {
                this.GetDataSourceNameListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataSourceNameListOperationCompleted);
            }
            this.InvokeAsync("GetDataSourceNameList", new object[0], this.GetDataSourceNameListOperationCompleted, userState);
        }
        private void OnGetDataSourceNameListOperationCompleted(object arg) {
            if ((this.GetDataSourceNameListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataSourceNameListCompleted(this, new GetDataSourceNameListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetLoggedOnDataSourceNameList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLoggedOnDataSourceNameList(string sessionTicket) {
            object[] results = this.Invoke("GetLoggedOnDataSourceNameList", new object[] {
                        sessionTicket});
            return ((string)(results[0]));
        }
        public void GetLoggedOnDataSourceNameListAsync(string sessionTicket) {
            this.GetLoggedOnDataSourceNameListAsync(sessionTicket, null);
        }
        public void GetLoggedOnDataSourceNameListAsync(string sessionTicket, object userState) {
            if ((this.GetLoggedOnDataSourceNameListOperationCompleted == null)) {
                this.GetLoggedOnDataSourceNameListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLoggedOnDataSourceNameListOperationCompleted);
            }
            this.InvokeAsync("GetLoggedOnDataSourceNameList", new object[] {
                        sessionTicket}, this.GetLoggedOnDataSourceNameListOperationCompleted, userState);
        }
        private void OnGetLoggedOnDataSourceNameListOperationCompleted(object arg) {
            if ((this.GetLoggedOnDataSourceNameListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLoggedOnDataSourceNameListCompleted(this, new GetLoggedOnDataSourceNameListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationList(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetApplicationList", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetApplicationListAsync(string sessionTicket, string dataSource) {
            this.GetApplicationListAsync(sessionTicket, dataSource, null);
        }
        public void GetApplicationListAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetApplicationListOperationCompleted == null)) {
                this.GetApplicationListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationListOperationCompleted);
            }
            this.InvokeAsync("GetApplicationList", new object[] {
                        sessionTicket,
                        dataSource}, this.GetApplicationListOperationCompleted, userState);
        }
        private void OnGetApplicationListOperationCompleted(object arg) {
            if ((this.GetApplicationListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationListCompleted(this, new GetApplicationListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ChangePassword", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangePassword(string sessionTicket, string dataSource, string oldPassword, string newPassword) {
            this.Invoke("ChangePassword", new object[] {
                        sessionTicket,
                        dataSource,
                        oldPassword,
                        newPassword});
        }
        public void ChangePasswordAsync(string sessionTicket, string dataSource, string oldPassword, string newPassword) {
            this.ChangePasswordAsync(sessionTicket, dataSource, oldPassword, newPassword, null);
        }
        public void ChangePasswordAsync(string sessionTicket, string dataSource, string oldPassword, string newPassword, object userState) {
            if ((this.ChangePasswordOperationCompleted == null)) {
                this.ChangePasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangePasswordOperationCompleted);
            }
            this.InvokeAsync("ChangePassword", new object[] {
                        sessionTicket,
                        dataSource,
                        oldPassword,
                        newPassword}, this.ChangePasswordOperationCompleted, userState);
        }
        private void OnChangePasswordOperationCompleted(object arg) {
            if ((this.ChangePasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangePasswordCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SecuredChangePassword", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SecuredChangePassword(string sessionTicket, string dataSource, string keyId, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] oldEncryptedPassword, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] newEncryptedPassword) {
            this.Invoke("SecuredChangePassword", new object[] {
                        sessionTicket,
                        dataSource,
                        keyId,
                        oldEncryptedPassword,
                        newEncryptedPassword});
        }
        public void SecuredChangePasswordAsync(string sessionTicket, string dataSource, string keyId, byte[] oldEncryptedPassword, byte[] newEncryptedPassword) {
            this.SecuredChangePasswordAsync(sessionTicket, dataSource, keyId, oldEncryptedPassword, newEncryptedPassword, null);
        }
        public void SecuredChangePasswordAsync(string sessionTicket, string dataSource, string keyId, byte[] oldEncryptedPassword, byte[] newEncryptedPassword, object userState) {
            if ((this.SecuredChangePasswordOperationCompleted == null)) {
                this.SecuredChangePasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSecuredChangePasswordOperationCompleted);
            }
            this.InvokeAsync("SecuredChangePassword", new object[] {
                        sessionTicket,
                        dataSource,
                        keyId,
                        oldEncryptedPassword,
                        newEncryptedPassword}, this.SecuredChangePasswordOperationCompleted, userState);
        }
        private void OnSecuredChangePasswordOperationCompleted(object arg) {
            if ((this.SecuredChangePasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SecuredChangePasswordCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetUserPermissions", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUserPermissions(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetUserPermissions", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetUserPermissionsAsync(string sessionTicket, string dataSource) {
            this.GetUserPermissionsAsync(sessionTicket, dataSource, null);
        }
        public void GetUserPermissionsAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetUserPermissionsOperationCompleted == null)) {
                this.GetUserPermissionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserPermissionsOperationCompleted);
            }
            this.InvokeAsync("GetUserPermissions", new object[] {
                        sessionTicket,
                        dataSource}, this.GetUserPermissionsOperationCompleted, userState);
        }
        private void OnGetUserPermissionsOperationCompleted(object arg) {
            if ((this.GetUserPermissionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserPermissionsCompleted(this, new GetUserPermissionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetPermissionsDefinition", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPermissionsDefinition(string sessionTicket) {
            object[] results = this.Invoke("GetPermissionsDefinition", new object[] {
                        sessionTicket});
            return ((string)(results[0]));
        }
        public void GetPermissionsDefinitionAsync(string sessionTicket) {
            this.GetPermissionsDefinitionAsync(sessionTicket, null);
        }
        public void GetPermissionsDefinitionAsync(string sessionTicket, object userState) {
            if ((this.GetPermissionsDefinitionOperationCompleted == null)) {
                this.GetPermissionsDefinitionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPermissionsDefinitionOperationCompleted);
            }
            this.InvokeAsync("GetPermissionsDefinition", new object[] {
                        sessionTicket}, this.GetPermissionsDefinitionOperationCompleted, userState);
        }
        private void OnGetPermissionsDefinitionOperationCompleted(object arg) {
            if ((this.GetPermissionsDefinitionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPermissionsDefinitionCompleted(this, new GetPermissionsDefinitionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetLicenseInfo", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLicenseInfo(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetLicenseInfo", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetLicenseInfoAsync(string sessionTicket, string dataSource) {
            this.GetLicenseInfoAsync(sessionTicket, dataSource, null);
        }
        public void GetLicenseInfoAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetLicenseInfoOperationCompleted == null)) {
                this.GetLicenseInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLicenseInfoOperationCompleted);
            }
            this.InvokeAsync("GetLicenseInfo", new object[] {
                        sessionTicket,
                        dataSource}, this.GetLicenseInfoOperationCompleted, userState);
        }
        private void OnGetLicenseInfoOperationCompleted(object arg) {
            if ((this.GetLicenseInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLicenseInfoCompleted(this, new GetLicenseInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetSessionTimeout", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetSessionTimeout() {
            object[] results = this.Invoke("GetSessionTimeout", new object[0]);
            return ((int)(results[0]));
        }
        public void GetSessionTimeoutAsync() {
            this.GetSessionTimeoutAsync(null);
        }
        public void GetSessionTimeoutAsync(object userState) {
            if ((this.GetSessionTimeoutOperationCompleted == null)) {
                this.GetSessionTimeoutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSessionTimeoutOperationCompleted);
            }
            this.InvokeAsync("GetSessionTimeout", new object[0], this.GetSessionTimeoutOperationCompleted, userState);
        }
        private void OnGetSessionTimeoutOperationCompleted(object arg) {
            if ((this.GetSessionTimeoutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSessionTimeoutCompleted(this, new GetSessionTimeoutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetSessionFeatures", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetSessionFeatures(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetSessionFeatures", new object[] {
                        sessionTicket,
                        dataSource});
            return ((int)(results[0]));
        }
        public void GetSessionFeaturesAsync(string sessionTicket, string dataSource) {
            this.GetSessionFeaturesAsync(sessionTicket, dataSource, null);
        }
        public void GetSessionFeaturesAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetSessionFeaturesOperationCompleted == null)) {
                this.GetSessionFeaturesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSessionFeaturesOperationCompleted);
            }
            this.InvokeAsync("GetSessionFeatures", new object[] {
                        sessionTicket,
                        dataSource}, this.GetSessionFeaturesOperationCompleted, userState);
        }
        private void OnGetSessionFeaturesOperationCompleted(object arg) {
            if ((this.GetSessionFeaturesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSessionFeaturesCompleted(this, new GetSessionFeaturesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetWorkflowProvider", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWorkflowProvider(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetWorkflowProvider", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetWorkflowProviderAsync(string sessionTicket, string dataSource) {
            this.GetWorkflowProviderAsync(sessionTicket, dataSource, null);
        }
        public void GetWorkflowProviderAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetWorkflowProviderOperationCompleted == null)) {
                this.GetWorkflowProviderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWorkflowProviderOperationCompleted);
            }
            this.InvokeAsync("GetWorkflowProvider", new object[] {
                        sessionTicket,
                        dataSource}, this.GetWorkflowProviderOperationCompleted, userState);
        }
        private void OnGetWorkflowProviderOperationCompleted(object arg) {
            if ((this.GetWorkflowProviderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWorkflowProviderCompleted(this, new GetWorkflowProviderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetAnnGroupSecurityMgr", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAnnGroupSecurityMgr(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetAnnGroupSecurityMgr", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetAnnGroupSecurityMgrAsync(string sessionTicket, string dataSource) {
            this.GetAnnGroupSecurityMgrAsync(sessionTicket, dataSource, null);
        }
        public void GetAnnGroupSecurityMgrAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetAnnGroupSecurityMgrOperationCompleted == null)) {
                this.GetAnnGroupSecurityMgrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAnnGroupSecurityMgrOperationCompleted);
            }
            this.InvokeAsync("GetAnnGroupSecurityMgr", new object[] {
                        sessionTicket,
                        dataSource}, this.GetAnnGroupSecurityMgrOperationCompleted, userState);
        }
        private void OnGetAnnGroupSecurityMgrOperationCompleted(object arg) {
            if ((this.GetAnnGroupSecurityMgrCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAnnGroupSecurityMgrCompleted(this, new GetAnnGroupSecurityMgrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetIrmMembers", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIrmMembers(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetIrmMembers", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetIrmMembersAsync(string sessionTicket, string dataSource) {
            this.GetIrmMembersAsync(sessionTicket, dataSource, null);
        }
        public void GetIrmMembersAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetIrmMembersOperationCompleted == null)) {
                this.GetIrmMembersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIrmMembersOperationCompleted);
            }
            this.InvokeAsync("GetIrmMembers", new object[] {
                        sessionTicket,
                        dataSource}, this.GetIrmMembersOperationCompleted, userState);
        }
        private void OnGetIrmMembersOperationCompleted(object arg) {
            if ((this.GetIrmMembersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIrmMembersCompleted(this, new GetIrmMembersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetAxViewerLicense", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAxViewerLicense(string sessionTicket, out string key, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] out byte[] sessionSignature) {
            object[] results = this.Invoke("GetAxViewerLicense", new object[] {
                        sessionTicket});
            key = ((string)(results[1]));
            sessionSignature = ((byte[])(results[2]));
            return ((string)(results[0]));
        }
        public void GetAxViewerLicenseAsync(string sessionTicket) {
            this.GetAxViewerLicenseAsync(sessionTicket, null);
        }
        public void GetAxViewerLicenseAsync(string sessionTicket, object userState) {
            if ((this.GetAxViewerLicenseOperationCompleted == null)) {
                this.GetAxViewerLicenseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAxViewerLicenseOperationCompleted);
            }
            this.InvokeAsync("GetAxViewerLicense", new object[] {
                        sessionTicket}, this.GetAxViewerLicenseOperationCompleted, userState);
        }
        private void OnGetAxViewerLicenseOperationCompleted(object arg) {
            if ((this.GetAxViewerLicenseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAxViewerLicenseCompleted(this, new GetAxViewerLicenseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetAxUsers", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAxUsers(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            object[] results = this.Invoke("GetAxUsers", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void GetAxUsersAsync(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            this.GetAxUsersAsync(sessionTicket, dataSource, startPosition, pageSize, null);
        }
        public void GetAxUsersAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, object userState) {
            if ((this.GetAxUsersOperationCompleted == null)) {
                this.GetAxUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAxUsersOperationCompleted);
            }
            this.InvokeAsync("GetAxUsers", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize}, this.GetAxUsersOperationCompleted, userState);
        }
        private void OnGetAxUsersOperationCompleted(object arg) {
            if ((this.GetAxUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAxUsersCompleted(this, new GetAxUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationFields", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationFields(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetApplicationFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetApplicationFieldsAsync(string sessionTicket, string dataSource, short appID) {
            this.GetApplicationFieldsAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetApplicationFieldsAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetApplicationFieldsOperationCompleted == null)) {
                this.GetApplicationFieldsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationFieldsOperationCompleted);
            }
            this.InvokeAsync("GetApplicationFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetApplicationFieldsOperationCompleted, userState);
        }
        private void OnGetApplicationFieldsOperationCompleted(object arg) {
            if ((this.GetApplicationFieldsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationFieldsCompleted(this, new GetApplicationFieldsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetODMAFields", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetODMAFields(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetODMAFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetODMAFieldsAsync(string sessionTicket, string dataSource, short appID) {
            this.GetODMAFieldsAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetODMAFieldsAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetODMAFieldsOperationCompleted == null)) {
                this.GetODMAFieldsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetODMAFieldsOperationCompleted);
            }
            this.InvokeAsync("GetODMAFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetODMAFieldsOperationCompleted, userState);
        }
        private void OnGetODMAFieldsOperationCompleted(object arg) {
            if ((this.GetODMAFieldsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetODMAFieldsCompleted(this, new GetODMAFieldsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetReportFields", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetReportFields(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetReportFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetReportFieldsAsync(string sessionTicket, string dataSource, short appID) {
            this.GetReportFieldsAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetReportFieldsAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetReportFieldsOperationCompleted == null)) {
                this.GetReportFieldsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetReportFieldsOperationCompleted);
            }
            this.InvokeAsync("GetReportFields", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetReportFieldsOperationCompleted, userState);
        }
        private void OnGetReportFieldsOperationCompleted(object arg) {
            if ((this.GetReportFieldsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetReportFieldsCompleted(this, new GetReportFieldsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationQueries", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationQueries(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetApplicationQueries", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetApplicationQueriesAsync(string sessionTicket, string dataSource, short appID) {
            this.GetApplicationQueriesAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetApplicationQueriesAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetApplicationQueriesOperationCompleted == null)) {
                this.GetApplicationQueriesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationQueriesOperationCompleted);
            }
            this.InvokeAsync("GetApplicationQueries", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetApplicationQueriesOperationCompleted, userState);
        }
        private void OnGetApplicationQueriesOperationCompleted(object arg) {
            if ((this.GetApplicationQueriesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationQueriesCompleted(this, new GetApplicationQueriesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetCAQQueries", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCAQQueries(string sessionTicket, string dataSource) {
            object[] results = this.Invoke("GetCAQQueries", new object[] {
                        sessionTicket,
                        dataSource});
            return ((string)(results[0]));
        }
        public void GetCAQQueriesAsync(string sessionTicket, string dataSource) {
            this.GetCAQQueriesAsync(sessionTicket, dataSource, null);
        }
        public void GetCAQQueriesAsync(string sessionTicket, string dataSource, object userState) {
            if ((this.GetCAQQueriesOperationCompleted == null)) {
                this.GetCAQQueriesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCAQQueriesOperationCompleted);
            }
            this.InvokeAsync("GetCAQQueries", new object[] {
                        sessionTicket,
                        dataSource}, this.GetCAQQueriesOperationCompleted, userState);
        }
        private void OnGetCAQQueriesOperationCompleted(object arg) {
            if ((this.GetCAQQueriesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCAQQueriesCompleted(this, new GetCAQQueriesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationsData", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationsData(string sessionTicket, string dataSource, short[] appIds) {
            object[] results = this.Invoke("GetApplicationsData", new object[] {
                        sessionTicket,
                        dataSource,
                        appIds});
            return ((string)(results[0]));
        }
        public void GetApplicationsDataAsync(string sessionTicket, string dataSource, short[] appIds) {
            this.GetApplicationsDataAsync(sessionTicket, dataSource, appIds, null);
        }
        public void GetApplicationsDataAsync(string sessionTicket, string dataSource, short[] appIds, object userState) {
            if ((this.GetApplicationsDataOperationCompleted == null)) {
                this.GetApplicationsDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationsDataOperationCompleted);
            }
            this.InvokeAsync("GetApplicationsData", new object[] {
                        sessionTicket,
                        dataSource,
                        appIds}, this.GetApplicationsDataOperationCompleted, userState);
        }
        private void OnGetApplicationsDataOperationCompleted(object arg) {
            if ((this.GetApplicationsDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationsDataCompleted(this, new GetApplicationsDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRetentionProvider", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRetentionProvider(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetRetentionProvider", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetRetentionProviderAsync(string sessionTicket, string dataSource, short appID) {
            this.GetRetentionProviderAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetRetentionProviderAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetRetentionProviderOperationCompleted == null)) {
                this.GetRetentionProviderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRetentionProviderOperationCompleted);
            }
            this.InvokeAsync("GetRetentionProvider", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetRetentionProviderOperationCompleted, userState);
        }
        private void OnGetRetentionProviderOperationCompleted(object arg) {
            if ((this.GetRetentionProviderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRetentionProviderCompleted(this, new GetRetentionProviderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationsHoldLabels", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationsHoldLabels(string sessionTicket, string dataSource, short appID) {
            object[] results = this.Invoke("GetApplicationsHoldLabels", new object[] {
                        sessionTicket,
                        dataSource,
                        appID});
            return ((string)(results[0]));
        }
        public void GetApplicationsHoldLabelsAsync(string sessionTicket, string dataSource, short appID) {
            this.GetApplicationsHoldLabelsAsync(sessionTicket, dataSource, appID, null);
        }
        public void GetApplicationsHoldLabelsAsync(string sessionTicket, string dataSource, short appID, object userState) {
            if ((this.GetApplicationsHoldLabelsOperationCompleted == null)) {
                this.GetApplicationsHoldLabelsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationsHoldLabelsOperationCompleted);
            }
            this.InvokeAsync("GetApplicationsHoldLabels", new object[] {
                        sessionTicket,
                        dataSource,
                        appID}, this.GetApplicationsHoldLabelsOperationCompleted, userState);
        }
        private void OnGetApplicationsHoldLabelsOperationCompleted(object arg) {
            if ((this.GetApplicationsHoldLabelsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationsHoldLabelsCompleted(this, new GetApplicationsHoldLabelsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocIdsWithHoldLabel", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocIdsWithHoldLabel(string sessionTicket, string dataSource, short appId, string holdLabel) {
            object[] results = this.Invoke("GetDocIdsWithHoldLabel", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        holdLabel});
            return ((string)(results[0]));
        }
        public void GetDocIdsWithHoldLabelAsync(string sessionTicket, string dataSource, short appId, string holdLabel) {
            this.GetDocIdsWithHoldLabelAsync(sessionTicket, dataSource, appId, holdLabel, null);
        }
        public void GetDocIdsWithHoldLabelAsync(string sessionTicket, string dataSource, short appId, string holdLabel, object userState) {
            if ((this.GetDocIdsWithHoldLabelOperationCompleted == null)) {
                this.GetDocIdsWithHoldLabelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocIdsWithHoldLabelOperationCompleted);
            }
            this.InvokeAsync("GetDocIdsWithHoldLabel", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        holdLabel}, this.GetDocIdsWithHoldLabelOperationCompleted, userState);
        }
        private void OnGetDocIdsWithHoldLabelOperationCompleted(object arg) {
            if ((this.GetDocIdsWithHoldLabelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocIdsWithHoldLabelCompleted(this, new GetDocIdsWithHoldLabelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRetentionConfiguration", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRetentionConfiguration(string sessionTicket, string dataSource, short appId) {
            object[] results = this.Invoke("GetRetentionConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        appId});
            return ((string)(results[0]));
        }
        public void GetRetentionConfigurationAsync(string sessionTicket, string dataSource, short appId) {
            this.GetRetentionConfigurationAsync(sessionTicket, dataSource, appId, null);
        }
        public void GetRetentionConfigurationAsync(string sessionTicket, string dataSource, short appId, object userState) {
            if ((this.GetRetentionConfigurationOperationCompleted == null)) {
                this.GetRetentionConfigurationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRetentionConfigurationOperationCompleted);
            }
            this.InvokeAsync("GetRetentionConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        appId}, this.GetRetentionConfigurationOperationCompleted, userState);
        }
        private void OnGetRetentionConfigurationOperationCompleted(object arg) {
            if ((this.GetRetentionConfigurationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRetentionConfigurationCompleted(this, new GetRetentionConfigurationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetApplicationBusinessProcessList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApplicationBusinessProcessList(string sessionTicket, string dataSource, short appId) {
            object[] results = this.Invoke("GetApplicationBusinessProcessList", new object[] {
                        sessionTicket,
                        dataSource,
                        appId});
            return ((string)(results[0]));
        }
        public void GetApplicationBusinessProcessListAsync(string sessionTicket, string dataSource, short appId) {
            this.GetApplicationBusinessProcessListAsync(sessionTicket, dataSource, appId, null);
        }
        public void GetApplicationBusinessProcessListAsync(string sessionTicket, string dataSource, short appId, object userState) {
            if ((this.GetApplicationBusinessProcessListOperationCompleted == null)) {
                this.GetApplicationBusinessProcessListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApplicationBusinessProcessListOperationCompleted);
            }
            this.InvokeAsync("GetApplicationBusinessProcessList", new object[] {
                        sessionTicket,
                        dataSource,
                        appId}, this.GetApplicationBusinessProcessListOperationCompleted, userState);
        }
        private void OnGetApplicationBusinessProcessListOperationCompleted(object arg) {
            if ((this.GetApplicationBusinessProcessListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApplicationBusinessProcessListCompleted(this, new GetApplicationBusinessProcessListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/OpenDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OpenDocument(string sessionTicket, string xmlAxDocumentPointer, bool openReadonly, bool checkOut, string checkoutComments) {
            object[] results = this.Invoke("OpenDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        openReadonly,
                        checkOut,
                        checkoutComments});
            return ((string)(results[0]));
        }
        public void OpenDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, bool openReadonly, bool checkOut, string checkoutComments) {
            this.OpenDocumentAsync(sessionTicket, xmlAxDocumentPointer, openReadonly, checkOut, checkoutComments, null);
        }
        public void OpenDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, bool openReadonly, bool checkOut, string checkoutComments, object userState) {
            if ((this.OpenDocumentOperationCompleted == null)) {
                this.OpenDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOpenDocumentOperationCompleted);
            }
            this.InvokeAsync("OpenDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        openReadonly,
                        checkOut,
                        checkoutComments}, this.OpenDocumentOperationCompleted, userState);
        }
        private void OnOpenDocumentOperationCompleted(object arg) {
            if ((this.OpenDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OpenDocumentCompleted(this, new OpenDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/OpenDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OpenDocumentByRef(string sessionTicket, string docReference, bool openReadonly, bool checkOut, string checkoutComments) {
            object[] results = this.Invoke("OpenDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        openReadonly,
                        checkOut,
                        checkoutComments});
            return ((string)(results[0]));
        }
        public void OpenDocumentByRefAsync(string sessionTicket, string docReference, bool openReadonly, bool checkOut, string checkoutComments) {
            this.OpenDocumentByRefAsync(sessionTicket, docReference, openReadonly, checkOut, checkoutComments, null);
        }
        public void OpenDocumentByRefAsync(string sessionTicket, string docReference, bool openReadonly, bool checkOut, string checkoutComments, object userState) {
            if ((this.OpenDocumentByRefOperationCompleted == null)) {
                this.OpenDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOpenDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("OpenDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        openReadonly,
                        checkOut,
                        checkoutComments}, this.OpenDocumentByRefOperationCompleted, userState);
        }
        private void OnOpenDocumentByRefOperationCompleted(object arg) {
            if ((this.OpenDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OpenDocumentByRefCompleted(this, new OpenDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CloseDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CloseDocument(string sessionTicket, string xmlAxDocumentPointer, bool checkIn, string xmlCheckInData) {
            this.Invoke("CloseDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        checkIn,
                        xmlCheckInData});
        }
        public void CloseDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, bool checkIn, string xmlCheckInData) {
            this.CloseDocumentAsync(sessionTicket, xmlAxDocumentPointer, checkIn, xmlCheckInData, null);
        }
        public void CloseDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, bool checkIn, string xmlCheckInData, object userState) {
            if ((this.CloseDocumentOperationCompleted == null)) {
                this.CloseDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCloseDocumentOperationCompleted);
            }
            this.InvokeAsync("CloseDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        checkIn,
                        xmlCheckInData}, this.CloseDocumentOperationCompleted, userState);
        }
        private void OnCloseDocumentOperationCompleted(object arg) {
            if ((this.CloseDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CloseDocumentCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CloseDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CloseDocumentByRef(string sessionTicket, string docReference, bool checkIn, string xmlCheckInData) {
            this.Invoke("CloseDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        checkIn,
                        xmlCheckInData});
        }
        public void CloseDocumentByRefAsync(string sessionTicket, string docReference, bool checkIn, string xmlCheckInData) {
            this.CloseDocumentByRefAsync(sessionTicket, docReference, checkIn, xmlCheckInData, null);
        }
        public void CloseDocumentByRefAsync(string sessionTicket, string docReference, bool checkIn, string xmlCheckInData, object userState) {
            if ((this.CloseDocumentByRefOperationCompleted == null)) {
                this.CloseDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCloseDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("CloseDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        checkIn,
                        xmlCheckInData}, this.CloseDocumentByRefOperationCompleted, userState);
        }
        private void OnCloseDocumentByRefOperationCompleted(object arg) {
            if ((this.CloseDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CloseDocumentByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CreateNewDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateNewDocument(string sessionTicket, string xmlAxDocumentCreationData, string xmlDocIndex) {
            object[] results = this.Invoke("CreateNewDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentCreationData,
                        xmlDocIndex});
            return ((string)(results[0]));
        }
        public void CreateNewDocumentAsync(string sessionTicket, string xmlAxDocumentCreationData, string xmlDocIndex) {
            this.CreateNewDocumentAsync(sessionTicket, xmlAxDocumentCreationData, xmlDocIndex, null);
        }
        public void CreateNewDocumentAsync(string sessionTicket, string xmlAxDocumentCreationData, string xmlDocIndex, object userState) {
            if ((this.CreateNewDocumentOperationCompleted == null)) {
                this.CreateNewDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateNewDocumentOperationCompleted);
            }
            this.InvokeAsync("CreateNewDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentCreationData,
                        xmlDocIndex}, this.CreateNewDocumentOperationCompleted, userState);
        }
        private void OnCreateNewDocumentOperationCompleted(object arg) {
            if ((this.CreateNewDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateNewDocumentCompleted(this, new CreateNewDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CheckOutDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckOutDocument(string sessionTicket, string xmlAxDocumentPointer, string checkoutComments) {
            object[] results = this.Invoke("CheckOutDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        checkoutComments});
            return ((string)(results[0]));
        }
        public void CheckOutDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, string checkoutComments) {
            this.CheckOutDocumentAsync(sessionTicket, xmlAxDocumentPointer, checkoutComments, null);
        }
        public void CheckOutDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, string checkoutComments, object userState) {
            if ((this.CheckOutDocumentOperationCompleted == null)) {
                this.CheckOutDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckOutDocumentOperationCompleted);
            }
            this.InvokeAsync("CheckOutDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        checkoutComments}, this.CheckOutDocumentOperationCompleted, userState);
        }
        private void OnCheckOutDocumentOperationCompleted(object arg) {
            if ((this.CheckOutDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckOutDocumentCompleted(this, new CheckOutDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CheckOutDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckOutDocumentByRef(string sessionTicket, string docReference, string checkoutComments) {
            object[] results = this.Invoke("CheckOutDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        checkoutComments});
            return ((string)(results[0]));
        }
        public void CheckOutDocumentByRefAsync(string sessionTicket, string docReference, string checkoutComments) {
            this.CheckOutDocumentByRefAsync(sessionTicket, docReference, checkoutComments, null);
        }
        public void CheckOutDocumentByRefAsync(string sessionTicket, string docReference, string checkoutComments, object userState) {
            if ((this.CheckOutDocumentByRefOperationCompleted == null)) {
                this.CheckOutDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckOutDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("CheckOutDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        checkoutComments}, this.CheckOutDocumentByRefOperationCompleted, userState);
        }
        private void OnCheckOutDocumentByRefOperationCompleted(object arg) {
            if ((this.CheckOutDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckOutDocumentByRefCompleted(this, new CheckOutDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CheckInDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckInDocument(string sessionTicket, string xmlAxDocumentPointer, string xmlCheckInData) {
            object[] results = this.Invoke("CheckInDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlCheckInData});
            return ((string)(results[0]));
        }
        public void CheckInDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlCheckInData) {
            this.CheckInDocumentAsync(sessionTicket, xmlAxDocumentPointer, xmlCheckInData, null);
        }
        public void CheckInDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlCheckInData, object userState) {
            if ((this.CheckInDocumentOperationCompleted == null)) {
                this.CheckInDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckInDocumentOperationCompleted);
            }
            this.InvokeAsync("CheckInDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlCheckInData}, this.CheckInDocumentOperationCompleted, userState);
        }
        private void OnCheckInDocumentOperationCompleted(object arg) {
            if ((this.CheckInDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckInDocumentCompleted(this, new CheckInDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CheckInDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckInDocumentByRef(string sessionTicket, string docReference, string xmlCheckInData) {
            object[] results = this.Invoke("CheckInDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlCheckInData});
            return ((string)(results[0]));
        }
        public void CheckInDocumentByRefAsync(string sessionTicket, string docReference, string xmlCheckInData) {
            this.CheckInDocumentByRefAsync(sessionTicket, docReference, xmlCheckInData, null);
        }
        public void CheckInDocumentByRefAsync(string sessionTicket, string docReference, string xmlCheckInData, object userState) {
            if ((this.CheckInDocumentByRefOperationCompleted == null)) {
                this.CheckInDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckInDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("CheckInDocumentByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlCheckInData}, this.CheckInDocumentByRefOperationCompleted, userState);
        }
        private void OnCheckInDocumentByRefOperationCompleted(object arg) {
            if ((this.CheckInDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckInDocumentByRefCompleted(this, new CheckInDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CancelCheckOutDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CancelCheckOutDocument(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("CancelCheckOutDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void CancelCheckOutDocumentAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.CancelCheckOutDocumentAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void CancelCheckOutDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.CancelCheckOutDocumentOperationCompleted == null)) {
                this.CancelCheckOutDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelCheckOutDocumentOperationCompleted);
            }
            this.InvokeAsync("CancelCheckOutDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.CancelCheckOutDocumentOperationCompleted, userState);
        }
        private void OnCancelCheckOutDocumentOperationCompleted(object arg) {
            if ((this.CancelCheckOutDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CancelCheckOutDocumentCompleted(this, new CancelCheckOutDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CancelCheckOutDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CancelCheckOutDocumentByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("CancelCheckOutDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void CancelCheckOutDocumentByRefAsync(string sessionTicket, string docReference) {
            this.CancelCheckOutDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void CancelCheckOutDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.CancelCheckOutDocumentByRefOperationCompleted == null)) {
                this.CancelCheckOutDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelCheckOutDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("CancelCheckOutDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.CancelCheckOutDocumentByRefOperationCompleted, userState);
        }
        private void OnCancelCheckOutDocumentByRefOperationCompleted(object arg) {
            if ((this.CancelCheckOutDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CancelCheckOutDocumentByRefCompleted(this, new CancelCheckOutDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LockDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LockDocument(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("LockDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void LockDocumentAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.LockDocumentAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void LockDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.LockDocumentOperationCompleted == null)) {
                this.LockDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLockDocumentOperationCompleted);
            }
            this.InvokeAsync("LockDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.LockDocumentOperationCompleted, userState);
        }
        private void OnLockDocumentOperationCompleted(object arg) {
            if ((this.LockDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LockDocumentCompleted(this, new LockDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/LockDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LockDocumentByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("LockDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void LockDocumentByRefAsync(string sessionTicket, string docReference) {
            this.LockDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void LockDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.LockDocumentByRefOperationCompleted == null)) {
                this.LockDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLockDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("LockDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.LockDocumentByRefOperationCompleted, userState);
        }
        private void OnLockDocumentByRefOperationCompleted(object arg) {
            if ((this.LockDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LockDocumentByRefCompleted(this, new LockDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UnlockDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UnlockDocument(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("UnlockDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void UnlockDocumentAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.UnlockDocumentAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void UnlockDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.UnlockDocumentOperationCompleted == null)) {
                this.UnlockDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUnlockDocumentOperationCompleted);
            }
            this.InvokeAsync("UnlockDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.UnlockDocumentOperationCompleted, userState);
        }
        private void OnUnlockDocumentOperationCompleted(object arg) {
            if ((this.UnlockDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UnlockDocumentCompleted(this, new UnlockDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UnlockDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UnlockDocumentByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("UnlockDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void UnlockDocumentByRefAsync(string sessionTicket, string docReference) {
            this.UnlockDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void UnlockDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.UnlockDocumentByRefOperationCompleted == null)) {
                this.UnlockDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUnlockDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("UnlockDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.UnlockDocumentByRefOperationCompleted, userState);
        }
        private void OnUnlockDocumentByRefOperationCompleted(object arg) {
            if ((this.UnlockDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UnlockDocumentByRefCompleted(this, new UnlockDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UnlockDocumentsByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UnlockDocumentsByRef(string sessionTicket, string dataSource, string xmlDocReferences) {
            this.Invoke("UnlockDocumentsByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlDocReferences});
        }
        public void UnlockDocumentsByRefAsync(string sessionTicket, string dataSource, string xmlDocReferences) {
            this.UnlockDocumentsByRefAsync(sessionTicket, dataSource, xmlDocReferences, null);
        }
        public void UnlockDocumentsByRefAsync(string sessionTicket, string dataSource, string xmlDocReferences, object userState) {
            if ((this.UnlockDocumentsByRefOperationCompleted == null)) {
                this.UnlockDocumentsByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUnlockDocumentsByRefOperationCompleted);
            }
            this.InvokeAsync("UnlockDocumentsByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlDocReferences}, this.UnlockDocumentsByRefOperationCompleted, userState);
        }
        private void OnUnlockDocumentsByRefOperationCompleted(object arg) {
            if ((this.UnlockDocumentsByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UnlockDocumentsByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocument(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("DeleteDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void DeleteDocumentAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.DeleteDocumentAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void DeleteDocumentAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.DeleteDocumentOperationCompleted == null)) {
                this.DeleteDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentOperationCompleted);
            }
            this.InvokeAsync("DeleteDocument", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.DeleteDocumentOperationCompleted, userState);
        }
        private void OnDeleteDocumentOperationCompleted(object arg) {
            if ((this.DeleteDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentCompleted(this, new DeleteDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentByRef(string sessionTicket, string docReference) {
            object[] results = this.Invoke("DeleteDocumentByRef", new object[] {
                        sessionTicket,
                        docReference});
            return ((string)(results[0]));
        }
        public void DeleteDocumentByRefAsync(string sessionTicket, string docReference) {
            this.DeleteDocumentByRefAsync(sessionTicket, docReference, null);
        }
        public void DeleteDocumentByRefAsync(string sessionTicket, string docReference, object userState) {
            if ((this.DeleteDocumentByRefOperationCompleted == null)) {
                this.DeleteDocumentByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentByRef", new object[] {
                        sessionTicket,
                        docReference}, this.DeleteDocumentByRefOperationCompleted, userState);
        }
        private void OnDeleteDocumentByRefOperationCompleted(object arg) {
            if ((this.DeleteDocumentByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentByRefCompleted(this, new DeleteDocumentByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocuments", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocuments(string sessionTicket, string dataSource, string xmlDocItems) {
            object[] results = this.Invoke("DeleteDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlDocItems});
            return ((string)(results[0]));
        }
        public void DeleteDocumentsAsync(string sessionTicket, string dataSource, string xmlDocItems) {
            this.DeleteDocumentsAsync(sessionTicket, dataSource, xmlDocItems, null);
        }
        public void DeleteDocumentsAsync(string sessionTicket, string dataSource, string xmlDocItems, object userState) {
            if ((this.DeleteDocumentsOperationCompleted == null)) {
                this.DeleteDocumentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentsOperationCompleted);
            }
            this.InvokeAsync("DeleteDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlDocItems}, this.DeleteDocumentsOperationCompleted, userState);
        }
        private void OnDeleteDocumentsOperationCompleted(object arg) {
            if ((this.DeleteDocumentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentsCompleted(this, new DeleteDocumentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentsByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentsByRef(string sessionTicket, string xmlDocReferences) {
            object[] results = this.Invoke("DeleteDocumentsByRef", new object[] {
                        sessionTicket,
                        xmlDocReferences});
            return ((string)(results[0]));
        }
        public void DeleteDocumentsByRefAsync(string sessionTicket, string xmlDocReferences) {
            this.DeleteDocumentsByRefAsync(sessionTicket, xmlDocReferences, null);
        }
        public void DeleteDocumentsByRefAsync(string sessionTicket, string xmlDocReferences, object userState) {
            if ((this.DeleteDocumentsByRefOperationCompleted == null)) {
                this.DeleteDocumentsByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentsByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentsByRef", new object[] {
                        sessionTicket,
                        xmlDocReferences}, this.DeleteDocumentsByRefOperationCompleted, userState);
        }
        private void OnDeleteDocumentsByRefOperationCompleted(object arg) {
            if ((this.DeleteDocumentsByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentsByRefCompleted(this, new DeleteDocumentsByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentPageList", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentPageList(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageAmount) {
            object[] results = this.Invoke("GetDocumentPageList", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageAmount});
            return ((string)(results[0]));
        }
        public void GetDocumentPageListAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageAmount) {
            this.GetDocumentPageListAsync(sessionTicket, xmlAxDocumentPointer, startPosition, pageAmount, null);
        }
        public void GetDocumentPageListAsync(string sessionTicket, string xmlAxDocumentPointer, int startPosition, int pageAmount, object userState) {
            if ((this.GetDocumentPageListOperationCompleted == null)) {
                this.GetDocumentPageListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentPageListOperationCompleted);
            }
            this.InvokeAsync("GetDocumentPageList", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        startPosition,
                        pageAmount}, this.GetDocumentPageListOperationCompleted, userState);
        }
        private void OnGetDocumentPageListOperationCompleted(object arg) {
            if ((this.GetDocumentPageListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentPageListCompleted(this, new GetDocumentPageListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentPageListByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentPageListByRef(string sessionTicket, string docReference, int startPosition, int pageAmount) {
            object[] results = this.Invoke("GetDocumentPageListByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageAmount});
            return ((string)(results[0]));
        }
        public void GetDocumentPageListByRefAsync(string sessionTicket, string docReference, int startPosition, int pageAmount) {
            this.GetDocumentPageListByRefAsync(sessionTicket, docReference, startPosition, pageAmount, null);
        }
        public void GetDocumentPageListByRefAsync(string sessionTicket, string docReference, int startPosition, int pageAmount, object userState) {
            if ((this.GetDocumentPageListByRefOperationCompleted == null)) {
                this.GetDocumentPageListByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentPageListByRefOperationCompleted);
            }
            this.InvokeAsync("GetDocumentPageListByRef", new object[] {
                        sessionTicket,
                        docReference,
                        startPosition,
                        pageAmount}, this.GetDocumentPageListByRefOperationCompleted, userState);
        }
        private void OnGetDocumentPageListByRefOperationCompleted(object arg) {
            if ((this.GetDocumentPageListByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentPageListByRefCompleted(this, new GetDocumentPageListByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UploadDocumentPage", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UploadDocumentPage(string sessionTicket, string xmlAxDocumentPointer, string xmlAxPageUploadData) {
            object[] results = this.Invoke("UploadDocumentPage", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxPageUploadData});
            return ((string)(results[0]));
        }
        public void UploadDocumentPageAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxPageUploadData) {
            this.UploadDocumentPageAsync(sessionTicket, xmlAxDocumentPointer, xmlAxPageUploadData, null);
        }
        public void UploadDocumentPageAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxPageUploadData, object userState) {
            if ((this.UploadDocumentPageOperationCompleted == null)) {
                this.UploadDocumentPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadDocumentPageOperationCompleted);
            }
            this.InvokeAsync("UploadDocumentPage", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxPageUploadData}, this.UploadDocumentPageOperationCompleted, userState);
        }
        private void OnUploadDocumentPageOperationCompleted(object arg) {
            if ((this.UploadDocumentPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadDocumentPageCompleted(this, new UploadDocumentPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UploadDocumentPageByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UploadDocumentPageByRef(string sessionTicket, string docReference, string xmlAxPageUploadData) {
            object[] results = this.Invoke("UploadDocumentPageByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlAxPageUploadData});
            return ((string)(results[0]));
        }
        public void UploadDocumentPageByRefAsync(string sessionTicket, string docReference, string xmlAxPageUploadData) {
            this.UploadDocumentPageByRefAsync(sessionTicket, docReference, xmlAxPageUploadData, null);
        }
        public void UploadDocumentPageByRefAsync(string sessionTicket, string docReference, string xmlAxPageUploadData, object userState) {
            if ((this.UploadDocumentPageByRefOperationCompleted == null)) {
                this.UploadDocumentPageByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadDocumentPageByRefOperationCompleted);
            }
            this.InvokeAsync("UploadDocumentPageByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlAxPageUploadData}, this.UploadDocumentPageByRefOperationCompleted, userState);
        }
        private void OnUploadDocumentPageByRefOperationCompleted(object arg) {
            if ((this.UploadDocumentPageByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadDocumentPageByRefCompleted(this, new UploadDocumentPageByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UploadDocumentPageStreamByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UploadDocumentPageStreamByRef(string sessionTicket, string docReference, string xmlAxPageUploadData, string xmlAxStreamData) {
            object[] results = this.Invoke("UploadDocumentPageStreamByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlAxPageUploadData,
                        xmlAxStreamData});
            return ((string)(results[0]));
        }
        public void UploadDocumentPageStreamByRefAsync(string sessionTicket, string docReference, string xmlAxPageUploadData, string xmlAxStreamData) {
            this.UploadDocumentPageStreamByRefAsync(sessionTicket, docReference, xmlAxPageUploadData, xmlAxStreamData, null);
        }
        public void UploadDocumentPageStreamByRefAsync(string sessionTicket, string docReference, string xmlAxPageUploadData, string xmlAxStreamData, object userState) {
            if ((this.UploadDocumentPageStreamByRefOperationCompleted == null)) {
                this.UploadDocumentPageStreamByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadDocumentPageStreamByRefOperationCompleted);
            }
            this.InvokeAsync("UploadDocumentPageStreamByRef", new object[] {
                        sessionTicket,
                        docReference,
                        xmlAxPageUploadData,
                        xmlAxStreamData}, this.UploadDocumentPageStreamByRefOperationCompleted, userState);
        }
        private void OnUploadDocumentPageStreamByRefOperationCompleted(object arg) {
            if ((this.UploadDocumentPageStreamByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadDocumentPageStreamByRefCompleted(this, new UploadDocumentPageStreamByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentPage", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentPage(string sessionTicket, string dataSource, short appId, string xmlAxPage) {
            object[] results = this.Invoke("DeleteDocumentPage", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxPage});
            return ((string)(results[0]));
        }
        public void DeleteDocumentPageAsync(string sessionTicket, string dataSource, short appId, string xmlAxPage) {
            this.DeleteDocumentPageAsync(sessionTicket, dataSource, appId, xmlAxPage, null);
        }
        public void DeleteDocumentPageAsync(string sessionTicket, string dataSource, short appId, string xmlAxPage, object userState) {
            if ((this.DeleteDocumentPageOperationCompleted == null)) {
                this.DeleteDocumentPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentPageOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentPage", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxPage}, this.DeleteDocumentPageOperationCompleted, userState);
        }
        private void OnDeleteDocumentPageOperationCompleted(object arg) {
            if ((this.DeleteDocumentPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentPageCompleted(this, new DeleteDocumentPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentPageByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentPageByRef(string sessionTicket, string pageReference) {
            object[] results = this.Invoke("DeleteDocumentPageByRef", new object[] {
                        sessionTicket,
                        pageReference});
            return ((string)(results[0]));
        }
        public void DeleteDocumentPageByRefAsync(string sessionTicket, string pageReference) {
            this.DeleteDocumentPageByRefAsync(sessionTicket, pageReference, null);
        }
        public void DeleteDocumentPageByRefAsync(string sessionTicket, string pageReference, object userState) {
            if ((this.DeleteDocumentPageByRefOperationCompleted == null)) {
                this.DeleteDocumentPageByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentPageByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentPageByRef", new object[] {
                        sessionTicket,
                        pageReference}, this.DeleteDocumentPageByRefOperationCompleted, userState);
        }
        private void OnDeleteDocumentPageByRefOperationCompleted(object arg) {
            if ((this.DeleteDocumentPageByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentPageByRefCompleted(this, new DeleteDocumentPageByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryCheckedOutDocuments", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryCheckedOutDocuments(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryCheckedOutDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryCheckedOutDocumentsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits) {
            this.QueryCheckedOutDocumentsAsync(sessionTicket, dataSource, startPosition, pageSize, maxHits, null);
        }
        public void QueryCheckedOutDocumentsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryCheckedOutDocumentsOperationCompleted == null)) {
                this.QueryCheckedOutDocumentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryCheckedOutDocumentsOperationCompleted);
            }
            this.InvokeAsync("QueryCheckedOutDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryCheckedOutDocumentsOperationCompleted, userState);
        }
        private void OnQueryCheckedOutDocumentsOperationCompleted(object arg) {
            if ((this.QueryCheckedOutDocumentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryCheckedOutDocumentsCompleted(this, new QueryCheckedOutDocumentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseCheckedOutDocumentResults", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseCheckedOutDocumentResults(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseCheckedOutDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseCheckedOutDocumentResultsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            this.BrowseCheckedOutDocumentResultsAsync(sessionTicket, dataSource, startPosition, pageSize, null);
        }
        public void BrowseCheckedOutDocumentResultsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, object userState) {
            if ((this.BrowseCheckedOutDocumentResultsOperationCompleted == null)) {
                this.BrowseCheckedOutDocumentResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseCheckedOutDocumentResultsOperationCompleted);
            }
            this.InvokeAsync("BrowseCheckedOutDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize}, this.BrowseCheckedOutDocumentResultsOperationCompleted, userState);
        }
        private void OnBrowseCheckedOutDocumentResultsOperationCompleted(object arg) {
            if ((this.BrowseCheckedOutDocumentResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseCheckedOutDocumentResultsCompleted(this, new BrowseCheckedOutDocumentResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryLockedDocuments", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryLockedDocuments(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryLockedDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryLockedDocumentsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits) {
            this.QueryLockedDocumentsAsync(sessionTicket, dataSource, startPosition, pageSize, maxHits, null);
        }
        public void QueryLockedDocumentsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryLockedDocumentsOperationCompleted == null)) {
                this.QueryLockedDocumentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryLockedDocumentsOperationCompleted);
            }
            this.InvokeAsync("QueryLockedDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryLockedDocumentsOperationCompleted, userState);
        }
        private void OnQueryLockedDocumentsOperationCompleted(object arg) {
            if ((this.QueryLockedDocumentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryLockedDocumentsCompleted(this, new QueryLockedDocumentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseLockedDocumentResults", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseLockedDocumentResults(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseLockedDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseLockedDocumentResultsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize) {
            this.BrowseLockedDocumentResultsAsync(sessionTicket, dataSource, startPosition, pageSize, null);
        }
        public void BrowseLockedDocumentResultsAsync(string sessionTicket, string dataSource, int startPosition, int pageSize, object userState) {
            if ((this.BrowseLockedDocumentResultsOperationCompleted == null)) {
                this.BrowseLockedDocumentResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseLockedDocumentResultsOperationCompleted);
            }
            this.InvokeAsync("BrowseLockedDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        startPosition,
                        pageSize}, this.BrowseLockedDocumentResultsOperationCompleted, userState);
        }
        private void OnBrowseLockedDocumentResultsOperationCompleted(object arg) {
            if ((this.BrowseLockedDocumentResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseLockedDocumentResultsCompleted(this, new BrowseLockedDocumentResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentProperty", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentProperty(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("GetDocumentProperty", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void GetDocumentPropertyAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.GetDocumentPropertyAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void GetDocumentPropertyAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.GetDocumentPropertyOperationCompleted == null)) {
                this.GetDocumentPropertyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentPropertyOperationCompleted);
            }
            this.InvokeAsync("GetDocumentProperty", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.GetDocumentPropertyOperationCompleted, userState);
        }
        private void OnGetDocumentPropertyOperationCompleted(object arg) {
            if ((this.GetDocumentPropertyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentPropertyCompleted(this, new GetDocumentPropertyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentPropertyByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentPropertyByRef(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentPropertyByRef", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentPropertyByRefAsync(string sessionTicket, string docRef) {
            this.GetDocumentPropertyByRefAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentPropertyByRefAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentPropertyByRefOperationCompleted == null)) {
                this.GetDocumentPropertyByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentPropertyByRefOperationCompleted);
            }
            this.InvokeAsync("GetDocumentPropertyByRef", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentPropertyByRefOperationCompleted, userState);
        }
        private void OnGetDocumentPropertyByRefOperationCompleted(object arg) {
            if ((this.GetDocumentPropertyByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentPropertyByRefCompleted(this, new GetDocumentPropertyByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SetDocumentProperty", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetDocumentProperty(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentProperty) {
            this.Invoke("SetDocumentProperty", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentProperty});
        }
        public void SetDocumentPropertyAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentProperty) {
            this.SetDocumentPropertyAsync(sessionTicket, xmlAxDocumentPointer, xmlAxDocumentProperty, null);
        }
        public void SetDocumentPropertyAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentProperty, object userState) {
            if ((this.SetDocumentPropertyOperationCompleted == null)) {
                this.SetDocumentPropertyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDocumentPropertyOperationCompleted);
            }
            this.InvokeAsync("SetDocumentProperty", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentProperty}, this.SetDocumentPropertyOperationCompleted, userState);
        }
        private void OnSetDocumentPropertyOperationCompleted(object arg) {
            if ((this.SetDocumentPropertyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDocumentPropertyCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SetDocumentPropertyByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetDocumentPropertyByRef(string sessionTicket, string docRef, string xmlAxDocumentProperty) {
            this.Invoke("SetDocumentPropertyByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentProperty});
        }
        public void SetDocumentPropertyByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentProperty) {
            this.SetDocumentPropertyByRefAsync(sessionTicket, docRef, xmlAxDocumentProperty, null);
        }
        public void SetDocumentPropertyByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentProperty, object userState) {
            if ((this.SetDocumentPropertyByRefOperationCompleted == null)) {
                this.SetDocumentPropertyByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDocumentPropertyByRefOperationCompleted);
            }
            this.InvokeAsync("SetDocumentPropertyByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentProperty}, this.SetDocumentPropertyByRefOperationCompleted, userState);
        }
        private void OnSetDocumentPropertyByRefOperationCompleted(object arg) {
            if ((this.SetDocumentPropertyByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDocumentPropertyByRefCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentRevisions", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentRevisions(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("GetDocumentRevisions", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void GetDocumentRevisionsAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.GetDocumentRevisionsAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void GetDocumentRevisionsAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.GetDocumentRevisionsOperationCompleted == null)) {
                this.GetDocumentRevisionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentRevisionsOperationCompleted);
            }
            this.InvokeAsync("GetDocumentRevisions", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.GetDocumentRevisionsOperationCompleted, userState);
        }
        private void OnGetDocumentRevisionsOperationCompleted(object arg) {
            if ((this.GetDocumentRevisionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentRevisionsCompleted(this, new GetDocumentRevisionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentRevisionsByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentRevisionsByRef(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentRevisionsByRef", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentRevisionsByRefAsync(string sessionTicket, string docRef) {
            this.GetDocumentRevisionsByRefAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentRevisionsByRefAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentRevisionsByRefOperationCompleted == null)) {
                this.GetDocumentRevisionsByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentRevisionsByRefOperationCompleted);
            }
            this.InvokeAsync("GetDocumentRevisionsByRef", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentRevisionsByRefOperationCompleted, userState);
        }
        private void OnGetDocumentRevisionsByRefOperationCompleted(object arg) {
            if ((this.GetDocumentRevisionsByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentRevisionsByRefCompleted(this, new GetDocumentRevisionsByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentRevision", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentRevision(string sessionTicket, string xmlAxDocumentPointer, int revisionNum) {
            object[] results = this.Invoke("DeleteDocumentRevision", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        revisionNum});
            return ((string)(results[0]));
        }
        public void DeleteDocumentRevisionAsync(string sessionTicket, string xmlAxDocumentPointer, int revisionNum) {
            this.DeleteDocumentRevisionAsync(sessionTicket, xmlAxDocumentPointer, revisionNum, null);
        }
        public void DeleteDocumentRevisionAsync(string sessionTicket, string xmlAxDocumentPointer, int revisionNum, object userState) {
            if ((this.DeleteDocumentRevisionOperationCompleted == null)) {
                this.DeleteDocumentRevisionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentRevisionOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentRevision", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        revisionNum}, this.DeleteDocumentRevisionOperationCompleted, userState);
        }
        private void OnDeleteDocumentRevisionOperationCompleted(object arg) {
            if ((this.DeleteDocumentRevisionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentRevisionCompleted(this, new DeleteDocumentRevisionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteDocumentRevisionByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDocumentRevisionByRef(string sessionTicket, string docRef, int revisionNum) {
            object[] results = this.Invoke("DeleteDocumentRevisionByRef", new object[] {
                        sessionTicket,
                        docRef,
                        revisionNum});
            return ((string)(results[0]));
        }
        public void DeleteDocumentRevisionByRefAsync(string sessionTicket, string docRef, int revisionNum) {
            this.DeleteDocumentRevisionByRefAsync(sessionTicket, docRef, revisionNum, null);
        }
        public void DeleteDocumentRevisionByRefAsync(string sessionTicket, string docRef, int revisionNum, object userState) {
            if ((this.DeleteDocumentRevisionByRefOperationCompleted == null)) {
                this.DeleteDocumentRevisionByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDocumentRevisionByRefOperationCompleted);
            }
            this.InvokeAsync("DeleteDocumentRevisionByRef", new object[] {
                        sessionTicket,
                        docRef,
                        revisionNum}, this.DeleteDocumentRevisionByRefOperationCompleted, userState);
        }
        private void OnDeleteDocumentRevisionByRefOperationCompleted(object arg) {
            if ((this.DeleteDocumentRevisionByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDocumentRevisionByRefCompleted(this, new DeleteDocumentRevisionByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/MergePDFPages", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string MergePDFPages(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("MergePDFPages", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void MergePDFPagesAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.MergePDFPagesAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void MergePDFPagesAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.MergePDFPagesOperationCompleted == null)) {
                this.MergePDFPagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMergePDFPagesOperationCompleted);
            }
            this.InvokeAsync("MergePDFPages", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.MergePDFPagesOperationCompleted, userState);
        }
        private void OnMergePDFPagesOperationCompleted(object arg) {
            if ((this.MergePDFPagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MergePDFPagesCompleted(this, new MergePDFPagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/MergePDFPagesByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string MergePDFPagesByRef(string sessionTicket, string docRef) {
            object[] results = this.Invoke("MergePDFPagesByRef", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void MergePDFPagesByRefAsync(string sessionTicket, string docRef) {
            this.MergePDFPagesByRefAsync(sessionTicket, docRef, null);
        }
        public void MergePDFPagesByRefAsync(string sessionTicket, string docRef, object userState) {
            if ((this.MergePDFPagesByRefOperationCompleted == null)) {
                this.MergePDFPagesByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMergePDFPagesByRefOperationCompleted);
            }
            this.InvokeAsync("MergePDFPagesByRef", new object[] {
                        sessionTicket,
                        docRef}, this.MergePDFPagesByRefOperationCompleted, userState);
        }
        private void OnMergePDFPagesByRefOperationCompleted(object arg) {
            if ((this.MergePDFPagesByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MergePDFPagesByRefCompleted(this, new MergePDFPagesByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ExportDocumentPages", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExportDocumentPages(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentExportData) {
            object[] results = this.Invoke("ExportDocumentPages", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentExportData});
            return ((string)(results[0]));
        }
        public void ExportDocumentPagesAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentExportData) {
            this.ExportDocumentPagesAsync(sessionTicket, xmlAxDocumentPointer, xmlAxDocumentExportData, null);
        }
        public void ExportDocumentPagesAsync(string sessionTicket, string xmlAxDocumentPointer, string xmlAxDocumentExportData, object userState) {
            if ((this.ExportDocumentPagesOperationCompleted == null)) {
                this.ExportDocumentPagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExportDocumentPagesOperationCompleted);
            }
            this.InvokeAsync("ExportDocumentPages", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer,
                        xmlAxDocumentExportData}, this.ExportDocumentPagesOperationCompleted, userState);
        }
        private void OnExportDocumentPagesOperationCompleted(object arg) {
            if ((this.ExportDocumentPagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExportDocumentPagesCompleted(this, new ExportDocumentPagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ExportDocumentPagesByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExportDocumentPagesByRef(string sessionTicket, string docRef, string xmlAxDocumentExportData) {
            object[] results = this.Invoke("ExportDocumentPagesByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentExportData});
            return ((string)(results[0]));
        }
        public void ExportDocumentPagesByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentExportData) {
            this.ExportDocumentPagesByRefAsync(sessionTicket, docRef, xmlAxDocumentExportData, null);
        }
        public void ExportDocumentPagesByRefAsync(string sessionTicket, string docRef, string xmlAxDocumentExportData, object userState) {
            if ((this.ExportDocumentPagesByRefOperationCompleted == null)) {
                this.ExportDocumentPagesByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExportDocumentPagesByRefOperationCompleted);
            }
            this.InvokeAsync("ExportDocumentPagesByRef", new object[] {
                        sessionTicket,
                        docRef,
                        xmlAxDocumentExportData}, this.ExportDocumentPagesByRefOperationCompleted, userState);
        }
        private void OnExportDocumentPagesByRefOperationCompleted(object arg) {
            if ((this.ExportDocumentPagesByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExportDocumentPagesByRefCompleted(this, new ExportDocumentPagesByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetExportDocumentPagesResult", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetExportDocumentPagesResult(string sessionTicket, string dataSource, string key, bool outputToUserFile) {
            object[] results = this.Invoke("GetExportDocumentPagesResult", new object[] {
                        sessionTicket,
                        dataSource,
                        key,
                        outputToUserFile});
            return ((string)(results[0]));
        }
        public void GetExportDocumentPagesResultAsync(string sessionTicket, string dataSource, string key, bool outputToUserFile) {
            this.GetExportDocumentPagesResultAsync(sessionTicket, dataSource, key, outputToUserFile, null);
        }
        public void GetExportDocumentPagesResultAsync(string sessionTicket, string dataSource, string key, bool outputToUserFile, object userState) {
            if ((this.GetExportDocumentPagesResultOperationCompleted == null)) {
                this.GetExportDocumentPagesResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExportDocumentPagesResultOperationCompleted);
            }
            this.InvokeAsync("GetExportDocumentPagesResult", new object[] {
                        sessionTicket,
                        dataSource,
                        key,
                        outputToUserFile}, this.GetExportDocumentPagesResultOperationCompleted, userState);
        }
        private void OnGetExportDocumentPagesResultOperationCompleted(object arg) {
            if ((this.GetExportDocumentPagesResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExportDocumentPagesResultCompleted(this, new GetExportDocumentPagesResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentDisplayUrlByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentDisplayUrlByRef(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentDisplayUrlByRef", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentDisplayUrlByRefAsync(string sessionTicket, string docRef) {
            this.GetDocumentDisplayUrlByRefAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentDisplayUrlByRefAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentDisplayUrlByRefOperationCompleted == null)) {
                this.GetDocumentDisplayUrlByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentDisplayUrlByRefOperationCompleted);
            }
            this.InvokeAsync("GetDocumentDisplayUrlByRef", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentDisplayUrlByRefOperationCompleted, userState);
        }
        private void OnGetDocumentDisplayUrlByRefOperationCompleted(object arg) {
            if ((this.GetDocumentDisplayUrlByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentDisplayUrlByRefCompleted(this, new GetDocumentDisplayUrlByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentDisplayUrl", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentDisplayUrl(string sessionTicket, string xmlAxDocumentPointer) {
            object[] results = this.Invoke("GetDocumentDisplayUrl", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer});
            return ((string)(results[0]));
        }
        public void GetDocumentDisplayUrlAsync(string sessionTicket, string xmlAxDocumentPointer) {
            this.GetDocumentDisplayUrlAsync(sessionTicket, xmlAxDocumentPointer, null);
        }
        public void GetDocumentDisplayUrlAsync(string sessionTicket, string xmlAxDocumentPointer, object userState) {
            if ((this.GetDocumentDisplayUrlOperationCompleted == null)) {
                this.GetDocumentDisplayUrlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentDisplayUrlOperationCompleted);
            }
            this.InvokeAsync("GetDocumentDisplayUrl", new object[] {
                        sessionTicket,
                        xmlAxDocumentPointer}, this.GetDocumentDisplayUrlOperationCompleted, userState);
        }
        private void OnGetDocumentDisplayUrlOperationCompleted(object arg) {
            if ((this.GetDocumentDisplayUrlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentDisplayUrlCompleted(this, new GetDocumentDisplayUrlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/ReleaseDocumentsLock", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReleaseDocumentsLock(string sessionTicket, string dataSource, string xmlLockDocItems) {
            this.Invoke("ReleaseDocumentsLock", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlLockDocItems});
        }
        public void ReleaseDocumentsLockAsync(string sessionTicket, string dataSource, string xmlLockDocItems) {
            this.ReleaseDocumentsLockAsync(sessionTicket, dataSource, xmlLockDocItems, null);
        }
        public void ReleaseDocumentsLockAsync(string sessionTicket, string dataSource, string xmlLockDocItems, object userState) {
            if ((this.ReleaseDocumentsLockOperationCompleted == null)) {
                this.ReleaseDocumentsLockOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReleaseDocumentsLockOperationCompleted);
            }
            this.InvokeAsync("ReleaseDocumentsLock", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlLockDocItems}, this.ReleaseDocumentsLockOperationCompleted, userState);
        }
        private void OnReleaseDocumentsLockOperationCompleted(object arg) {
            if ((this.ReleaseDocumentsLockCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReleaseDocumentsLockCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/MoveDocumentPage", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void MoveDocumentPage(string sessionTicket, string docRef, int pageNum, int newPageNum) {
            this.Invoke("MoveDocumentPage", new object[] {
                        sessionTicket,
                        docRef,
                        pageNum,
                        newPageNum});
        }
        public void MoveDocumentPageAsync(string sessionTicket, string docRef, int pageNum, int newPageNum) {
            this.MoveDocumentPageAsync(sessionTicket, docRef, pageNum, newPageNum, null);
        }
        public void MoveDocumentPageAsync(string sessionTicket, string docRef, int pageNum, int newPageNum, object userState) {
            if ((this.MoveDocumentPageOperationCompleted == null)) {
                this.MoveDocumentPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMoveDocumentPageOperationCompleted);
            }
            this.InvokeAsync("MoveDocumentPage", new object[] {
                        sessionTicket,
                        docRef,
                        pageNum,
                        newPageNum}, this.MoveDocumentPageOperationCompleted, userState);
        }
        private void OnMoveDocumentPageOperationCompleted(object arg) {
            if ((this.MoveDocumentPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MoveDocumentPageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/CreateBatchFromDocumentPages", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateBatchFromDocumentPages(string sessionTicket, string docRef, short destAppId, bool bMove, bool bIncludePageVersions, string pageList, string batchName) {
            object[] results = this.Invoke("CreateBatchFromDocumentPages", new object[] {
                        sessionTicket,
                        docRef,
                        destAppId,
                        bMove,
                        bIncludePageVersions,
                        pageList,
                        batchName});
            return ((string)(results[0]));
        }
        public void CreateBatchFromDocumentPagesAsync(string sessionTicket, string docRef, short destAppId, bool bMove, bool bIncludePageVersions, string pageList, string batchName) {
            this.CreateBatchFromDocumentPagesAsync(sessionTicket, docRef, destAppId, bMove, bIncludePageVersions, pageList, batchName, null);
        }
        public void CreateBatchFromDocumentPagesAsync(string sessionTicket, string docRef, short destAppId, bool bMove, bool bIncludePageVersions, string pageList, string batchName, object userState) {
            if ((this.CreateBatchFromDocumentPagesOperationCompleted == null)) {
                this.CreateBatchFromDocumentPagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateBatchFromDocumentPagesOperationCompleted);
            }
            this.InvokeAsync("CreateBatchFromDocumentPages", new object[] {
                        sessionTicket,
                        docRef,
                        destAppId,
                        bMove,
                        bIncludePageVersions,
                        pageList,
                        batchName}, this.CreateBatchFromDocumentPagesOperationCompleted, userState);
        }
        private void OnCreateBatchFromDocumentPagesOperationCompleted(object arg) {
            if ((this.CreateBatchFromDocumentPagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateBatchFromDocumentPagesCompleted(this, new CreateBatchFromDocumentPagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SetDocumentRetention", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SetDocumentRetention(string sessionTicket, string docRef, bool isClass, string PolicyOrClassName, bool useOriginalRetStartDate) {
            object[] results = this.Invoke("SetDocumentRetention", new object[] {
                        sessionTicket,
                        docRef,
                        isClass,
                        PolicyOrClassName,
                        useOriginalRetStartDate});
            return ((string)(results[0]));
        }
        public void SetDocumentRetentionAsync(string sessionTicket, string docRef, bool isClass, string PolicyOrClassName, bool useOriginalRetStartDate) {
            this.SetDocumentRetentionAsync(sessionTicket, docRef, isClass, PolicyOrClassName, useOriginalRetStartDate, null);
        }
        public void SetDocumentRetentionAsync(string sessionTicket, string docRef, bool isClass, string PolicyOrClassName, bool useOriginalRetStartDate, object userState) {
            if ((this.SetDocumentRetentionOperationCompleted == null)) {
                this.SetDocumentRetentionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDocumentRetentionOperationCompleted);
            }
            this.InvokeAsync("SetDocumentRetention", new object[] {
                        sessionTicket,
                        docRef,
                        isClass,
                        PolicyOrClassName,
                        useOriginalRetStartDate}, this.SetDocumentRetentionOperationCompleted, userState);
        }
        private void OnSetDocumentRetentionOperationCompleted(object arg) {
            if ((this.SetDocumentRetentionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDocumentRetentionCompleted(this, new SetDocumentRetentionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SetDocumentRetentionHold", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SetDocumentRetentionHold(string sessionTicket, string docRef, string holdLabel) {
            object[] results = this.Invoke("SetDocumentRetentionHold", new object[] {
                        sessionTicket,
                        docRef,
                        holdLabel});
            return ((string)(results[0]));
        }
        public void SetDocumentRetentionHoldAsync(string sessionTicket, string docRef, string holdLabel) {
            this.SetDocumentRetentionHoldAsync(sessionTicket, docRef, holdLabel, null);
        }
        public void SetDocumentRetentionHoldAsync(string sessionTicket, string docRef, string holdLabel, object userState) {
            if ((this.SetDocumentRetentionHoldOperationCompleted == null)) {
                this.SetDocumentRetentionHoldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDocumentRetentionHoldOperationCompleted);
            }
            this.InvokeAsync("SetDocumentRetentionHold", new object[] {
                        sessionTicket,
                        docRef,
                        holdLabel}, this.SetDocumentRetentionHoldOperationCompleted, userState);
        }
        private void OnSetDocumentRetentionHoldOperationCompleted(object arg) {
            if ((this.SetDocumentRetentionHoldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDocumentRetentionHoldCompleted(this, new SetDocumentRetentionHoldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentHoldLabel", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentHoldLabel(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentHoldLabel", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentHoldLabelAsync(string sessionTicket, string docRef) {
            this.GetDocumentHoldLabelAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentHoldLabelAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentHoldLabelOperationCompleted == null)) {
                this.GetDocumentHoldLabelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentHoldLabelOperationCompleted);
            }
            this.InvokeAsync("GetDocumentHoldLabel", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentHoldLabelOperationCompleted, userState);
        }
        private void OnGetDocumentHoldLabelOperationCompleted(object arg) {
            if ((this.GetDocumentHoldLabelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentHoldLabelCompleted(this, new GetDocumentHoldLabelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/RemoveDocumentRetentionHold", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RemoveDocumentRetentionHold(string sessionTicket, string docRef) {
            object[] results = this.Invoke("RemoveDocumentRetentionHold", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void RemoveDocumentRetentionHoldAsync(string sessionTicket, string docRef) {
            this.RemoveDocumentRetentionHoldAsync(sessionTicket, docRef, null);
        }
        public void RemoveDocumentRetentionHoldAsync(string sessionTicket, string docRef, object userState) {
            if ((this.RemoveDocumentRetentionHoldOperationCompleted == null)) {
                this.RemoveDocumentRetentionHoldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveDocumentRetentionHoldOperationCompleted);
            }
            this.InvokeAsync("RemoveDocumentRetentionHold", new object[] {
                        sessionTicket,
                        docRef}, this.RemoveDocumentRetentionHoldOperationCompleted, userState);
        }
        private void OnRemoveDocumentRetentionHoldOperationCompleted(object arg) {
            if ((this.RemoveDocumentRetentionHoldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveDocumentRetentionHoldCompleted(this, new RemoveDocumentRetentionHoldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentRetentionStartDateAsFiletime", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentRetentionStartDateAsFiletime(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentRetentionStartDateAsFiletime", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentRetentionStartDateAsFiletimeAsync(string sessionTicket, string docRef) {
            this.GetDocumentRetentionStartDateAsFiletimeAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentRetentionStartDateAsFiletimeAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentRetentionStartDateAsFiletimeOperationCompleted == null)) {
                this.GetDocumentRetentionStartDateAsFiletimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentRetentionStartDateAsFiletimeOperationCompleted);
            }
            this.InvokeAsync("GetDocumentRetentionStartDateAsFiletime", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentRetentionStartDateAsFiletimeOperationCompleted, userState);
        }
        private void OnGetDocumentRetentionStartDateAsFiletimeOperationCompleted(object arg) {
            if ((this.GetDocumentRetentionStartDateAsFiletimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentRetentionStartDateAsFiletimeCompleted(this, new GetDocumentRetentionStartDateAsFiletimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetDocumentRetentionEndDateAsFiletime", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentRetentionEndDateAsFiletime(string sessionTicket, string docRef) {
            object[] results = this.Invoke("GetDocumentRetentionEndDateAsFiletime", new object[] {
                        sessionTicket,
                        docRef});
            return ((string)(results[0]));
        }
        public void GetDocumentRetentionEndDateAsFiletimeAsync(string sessionTicket, string docRef) {
            this.GetDocumentRetentionEndDateAsFiletimeAsync(sessionTicket, docRef, null);
        }
        public void GetDocumentRetentionEndDateAsFiletimeAsync(string sessionTicket, string docRef, object userState) {
            if ((this.GetDocumentRetentionEndDateAsFiletimeOperationCompleted == null)) {
                this.GetDocumentRetentionEndDateAsFiletimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentRetentionEndDateAsFiletimeOperationCompleted);
            }
            this.InvokeAsync("GetDocumentRetentionEndDateAsFiletime", new object[] {
                        sessionTicket,
                        docRef}, this.GetDocumentRetentionEndDateAsFiletimeOperationCompleted, userState);
        }
        private void OnGetDocumentRetentionEndDateAsFiletimeOperationCompleted(object arg) {
            if ((this.GetDocumentRetentionEndDateAsFiletimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentRetentionEndDateAsFiletimeCompleted(this, new GetDocumentRetentionEndDateAsFiletimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/StartBusinessProcessOnDocument", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StartBusinessProcessOnDocument(string sessionTicket, string businessProcess, string docRef, int rsID) {
            this.Invoke("StartBusinessProcessOnDocument", new object[] {
                        sessionTicket,
                        businessProcess,
                        docRef,
                        rsID});
        }
        public void StartBusinessProcessOnDocumentAsync(string sessionTicket, string businessProcess, string docRef, int rsID) {
            this.StartBusinessProcessOnDocumentAsync(sessionTicket, businessProcess, docRef, rsID, null);
        }
        public void StartBusinessProcessOnDocumentAsync(string sessionTicket, string businessProcess, string docRef, int rsID, object userState) {
            if ((this.StartBusinessProcessOnDocumentOperationCompleted == null)) {
                this.StartBusinessProcessOnDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStartBusinessProcessOnDocumentOperationCompleted);
            }
            this.InvokeAsync("StartBusinessProcessOnDocument", new object[] {
                        sessionTicket,
                        businessProcess,
                        docRef,
                        rsID}, this.StartBusinessProcessOnDocumentOperationCompleted, userState);
        }
        private void OnStartBusinessProcessOnDocumentOperationCompleted(object arg) {
            if ((this.StartBusinessProcessOnDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StartBusinessProcessOnDocumentCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetIrmPolicyTemplates", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIrmPolicyTemplates(string sessionTicket, string docRef, int rsID) {
            object[] results = this.Invoke("GetIrmPolicyTemplates", new object[] {
                        sessionTicket,
                        docRef,
                        rsID});
            return ((string)(results[0]));
        }
        public void GetIrmPolicyTemplatesAsync(string sessionTicket, string docRef, int rsID) {
            this.GetIrmPolicyTemplatesAsync(sessionTicket, docRef, rsID, null);
        }
        public void GetIrmPolicyTemplatesAsync(string sessionTicket, string docRef, int rsID, object userState) {
            if ((this.GetIrmPolicyTemplatesOperationCompleted == null)) {
                this.GetIrmPolicyTemplatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIrmPolicyTemplatesOperationCompleted);
            }
            this.InvokeAsync("GetIrmPolicyTemplates", new object[] {
                        sessionTicket,
                        docRef,
                        rsID}, this.GetIrmPolicyTemplatesOperationCompleted, userState);
        }
        private void OnGetIrmPolicyTemplatesOperationCompleted(object arg) {
            if ((this.GetIrmPolicyTemplatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIrmPolicyTemplatesCompleted(this, new GetIrmPolicyTemplatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryDocuments", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryDocuments(string sessionTicket, string dataSource, string xmlAxQueryData, int startPosition, int pageSize, int maxHits, bool saveQuery, bool saveAsPrivate) {
            object[] results = this.Invoke("QueryDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxQueryData,
                        startPosition,
                        pageSize,
                        maxHits,
                        saveQuery,
                        saveAsPrivate});
            return ((string)(results[0]));
        }
        public void QueryDocumentsAsync(string sessionTicket, string dataSource, string xmlAxQueryData, int startPosition, int pageSize, int maxHits, bool saveQuery, bool saveAsPrivate) {
            this.QueryDocumentsAsync(sessionTicket, dataSource, xmlAxQueryData, startPosition, pageSize, maxHits, saveQuery, saveAsPrivate, null);
        }
        public void QueryDocumentsAsync(string sessionTicket, string dataSource, string xmlAxQueryData, int startPosition, int pageSize, int maxHits, bool saveQuery, bool saveAsPrivate, object userState) {
            if ((this.QueryDocumentsOperationCompleted == null)) {
                this.QueryDocumentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryDocumentsOperationCompleted);
            }
            this.InvokeAsync("QueryDocuments", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxQueryData,
                        startPosition,
                        pageSize,
                        maxHits,
                        saveQuery,
                        saveAsPrivate}, this.QueryDocumentsOperationCompleted, userState);
        }
        private void OnQueryDocumentsOperationCompleted(object arg) {
            if ((this.QueryDocumentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryDocumentsCompleted(this, new QueryDocumentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseDocumentResults", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseDocumentResults(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseDocumentResultsAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            this.BrowseDocumentResultsAsync(sessionTicket, dataSource, appId, startPosition, pageSize, null);
        }
        public void BrowseDocumentResultsAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize, object userState) {
            if ((this.BrowseDocumentResultsOperationCompleted == null)) {
                this.BrowseDocumentResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseDocumentResultsOperationCompleted);
            }
            this.InvokeAsync("BrowseDocumentResults", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize}, this.BrowseDocumentResultsOperationCompleted, userState);
        }
        private void OnBrowseDocumentResultsOperationCompleted(object arg) {
            if ((this.BrowseDocumentResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseDocumentResultsCompleted(this, new BrowseDocumentResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveQuery", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SaveQuery(string sessionTicket, string dataSource, string xmlAxQueryData, bool savePrivate) {
            this.Invoke("SaveQuery", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxQueryData,
                        savePrivate});
        }
        public void SaveQueryAsync(string sessionTicket, string dataSource, string xmlAxQueryData, bool savePrivate) {
            this.SaveQueryAsync(sessionTicket, dataSource, xmlAxQueryData, savePrivate, null);
        }
        public void SaveQueryAsync(string sessionTicket, string dataSource, string xmlAxQueryData, bool savePrivate, object userState) {
            if ((this.SaveQueryOperationCompleted == null)) {
                this.SaveQueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveQueryOperationCompleted);
            }
            this.InvokeAsync("SaveQuery", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxQueryData,
                        savePrivate}, this.SaveQueryOperationCompleted, userState);
        }
        private void OnSaveQueryOperationCompleted(object arg) {
            if ((this.SaveQueryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveQueryCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeleteQuery", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteQuery(string sessionTicket, string dataSource, short appId, int queryId) {
            this.Invoke("DeleteQuery", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        queryId});
        }
        public void DeleteQueryAsync(string sessionTicket, string dataSource, short appId, int queryId) {
            this.DeleteQueryAsync(sessionTicket, dataSource, appId, queryId, null);
        }
        public void DeleteQueryAsync(string sessionTicket, string dataSource, short appId, int queryId, object userState) {
            if ((this.DeleteQueryOperationCompleted == null)) {
                this.DeleteQueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteQueryOperationCompleted);
            }
            this.InvokeAsync("DeleteQuery", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        queryId}, this.DeleteQueryOperationCompleted, userState);
        }
        private void OnDeleteQueryOperationCompleted(object arg) {
            if ((this.DeleteQueryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteQueryCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryApplicationIndexesByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryApplicationIndexesByAppId(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryApplicationIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        outerJoin,
                        ignoreTimestamp,
                        xmlAxDocumentIndexQueryData,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryApplicationIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits) {
            this.QueryApplicationIndexesByAppIdAsync(sessionTicket, dataSource, appId, outerJoin, ignoreTimestamp, xmlAxDocumentIndexQueryData, startPosition, pageSize, maxHits, null);
        }
        public void QueryApplicationIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryApplicationIndexesByAppIdOperationCompleted == null)) {
                this.QueryApplicationIndexesByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryApplicationIndexesByAppIdOperationCompleted);
            }
            this.InvokeAsync("QueryApplicationIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        outerJoin,
                        ignoreTimestamp,
                        xmlAxDocumentIndexQueryData,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryApplicationIndexesByAppIdOperationCompleted, userState);
        }
        private void OnQueryApplicationIndexesByAppIdOperationCompleted(object arg) {
            if ((this.QueryApplicationIndexesByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryApplicationIndexesByAppIdCompleted(this, new QueryApplicationIndexesByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryApplicationIndexesByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryApplicationIndexesByAppName(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryApplicationIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        outerJoin,
                        ignoreTimestamp,
                        xmlAxDocumentIndexQueryData,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryApplicationIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits) {
            this.QueryApplicationIndexesByAppNameAsync(sessionTicket, dataSource, appName, outerJoin, ignoreTimestamp, xmlAxDocumentIndexQueryData, startPosition, pageSize, maxHits, null);
        }
        public void QueryApplicationIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlAxDocumentIndexQueryData, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryApplicationIndexesByAppNameOperationCompleted == null)) {
                this.QueryApplicationIndexesByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryApplicationIndexesByAppNameOperationCompleted);
            }
            this.InvokeAsync("QueryApplicationIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        outerJoin,
                        ignoreTimestamp,
                        xmlAxDocumentIndexQueryData,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryApplicationIndexesByAppNameOperationCompleted, userState);
        }
        private void OnQueryApplicationIndexesByAppNameOperationCompleted(object arg) {
            if ((this.QueryApplicationIndexesByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryApplicationIndexesByAppNameCompleted(this, new QueryApplicationIndexesByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/RequeryApplicationIndexesByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RequeryApplicationIndexesByAppId(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("RequeryApplicationIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        outerJoin,
                        ignoreTimestamp,
                        xmlDocIndex,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void RequeryApplicationIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits) {
            this.RequeryApplicationIndexesByAppIdAsync(sessionTicket, dataSource, appId, outerJoin, ignoreTimestamp, xmlDocIndex, startPosition, pageSize, maxHits, null);
        }
        public void RequeryApplicationIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.RequeryApplicationIndexesByAppIdOperationCompleted == null)) {
                this.RequeryApplicationIndexesByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequeryApplicationIndexesByAppIdOperationCompleted);
            }
            this.InvokeAsync("RequeryApplicationIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        outerJoin,
                        ignoreTimestamp,
                        xmlDocIndex,
                        startPosition,
                        pageSize,
                        maxHits}, this.RequeryApplicationIndexesByAppIdOperationCompleted, userState);
        }
        private void OnRequeryApplicationIndexesByAppIdOperationCompleted(object arg) {
            if ((this.RequeryApplicationIndexesByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequeryApplicationIndexesByAppIdCompleted(this, new RequeryApplicationIndexesByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/RequeryApplicationIndexesByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RequeryApplicationIndexesByAppName(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("RequeryApplicationIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        outerJoin,
                        ignoreTimestamp,
                        xmlDocIndex,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void RequeryApplicationIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits) {
            this.RequeryApplicationIndexesByAppNameAsync(sessionTicket, dataSource, appName, outerJoin, ignoreTimestamp, xmlDocIndex, startPosition, pageSize, maxHits, null);
        }
        public void RequeryApplicationIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, bool outerJoin, bool ignoreTimestamp, string xmlDocIndex, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.RequeryApplicationIndexesByAppNameOperationCompleted == null)) {
                this.RequeryApplicationIndexesByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequeryApplicationIndexesByAppNameOperationCompleted);
            }
            this.InvokeAsync("RequeryApplicationIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        outerJoin,
                        ignoreTimestamp,
                        xmlDocIndex,
                        startPosition,
                        pageSize,
                        maxHits}, this.RequeryApplicationIndexesByAppNameOperationCompleted, userState);
        }
        private void OnRequeryApplicationIndexesByAppNameOperationCompleted(object arg) {
            if ((this.RequeryApplicationIndexesByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequeryApplicationIndexesByAppNameCompleted(this, new RequeryApplicationIndexesByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseApplicationIndexResultsByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseApplicationIndexResultsByAppId(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseApplicationIndexResultsByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseApplicationIndexResultsByAppIdAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            this.BrowseApplicationIndexResultsByAppIdAsync(sessionTicket, dataSource, appId, startPosition, pageSize, null);
        }
        public void BrowseApplicationIndexResultsByAppIdAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize, object userState) {
            if ((this.BrowseApplicationIndexResultsByAppIdOperationCompleted == null)) {
                this.BrowseApplicationIndexResultsByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseApplicationIndexResultsByAppIdOperationCompleted);
            }
            this.InvokeAsync("BrowseApplicationIndexResultsByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize}, this.BrowseApplicationIndexResultsByAppIdOperationCompleted, userState);
        }
        private void OnBrowseApplicationIndexResultsByAppIdOperationCompleted(object arg) {
            if ((this.BrowseApplicationIndexResultsByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseApplicationIndexResultsByAppIdCompleted(this, new BrowseApplicationIndexResultsByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseApplicationIndexResultsByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseApplicationIndexResultsByAppName(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseApplicationIndexResultsByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseApplicationIndexResultsByAppNameAsync(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize) {
            this.BrowseApplicationIndexResultsByAppNameAsync(sessionTicket, dataSource, appName, startPosition, pageSize, null);
        }
        public void BrowseApplicationIndexResultsByAppNameAsync(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize, object userState) {
            if ((this.BrowseApplicationIndexResultsByAppNameOperationCompleted == null)) {
                this.BrowseApplicationIndexResultsByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseApplicationIndexResultsByAppNameOperationCompleted);
            }
            this.InvokeAsync("BrowseApplicationIndexResultsByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        startPosition,
                        pageSize}, this.BrowseApplicationIndexResultsByAppNameOperationCompleted, userState);
        }
        private void OnBrowseApplicationIndexResultsByAppNameOperationCompleted(object arg) {
            if ((this.BrowseApplicationIndexResultsByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseApplicationIndexResultsByAppNameCompleted(this, new BrowseApplicationIndexResultsByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryAutoIndexesByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryAutoIndexesByAppId(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryAutoIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxDocumentIndexQueryData,
                        ignoreTimestamp,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryAutoIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits) {
            this.QueryAutoIndexesByAppIdAsync(sessionTicket, dataSource, appId, xmlAxDocumentIndexQueryData, ignoreTimestamp, startPosition, pageSize, maxHits, null);
        }
        public void QueryAutoIndexesByAppIdAsync(string sessionTicket, string dataSource, short appId, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryAutoIndexesByAppIdOperationCompleted == null)) {
                this.QueryAutoIndexesByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryAutoIndexesByAppIdOperationCompleted);
            }
            this.InvokeAsync("QueryAutoIndexesByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        xmlAxDocumentIndexQueryData,
                        ignoreTimestamp,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryAutoIndexesByAppIdOperationCompleted, userState);
        }
        private void OnQueryAutoIndexesByAppIdOperationCompleted(object arg) {
            if ((this.QueryAutoIndexesByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryAutoIndexesByAppIdCompleted(this, new QueryAutoIndexesByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/QueryAutoIndexesByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string QueryAutoIndexesByAppName(string sessionTicket, string dataSource, string appName, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits) {
            object[] results = this.Invoke("QueryAutoIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        xmlAxDocumentIndexQueryData,
                        ignoreTimestamp,
                        startPosition,
                        pageSize,
                        maxHits});
            return ((string)(results[0]));
        }
        public void QueryAutoIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits) {
            this.QueryAutoIndexesByAppNameAsync(sessionTicket, dataSource, appName, xmlAxDocumentIndexQueryData, ignoreTimestamp, startPosition, pageSize, maxHits, null);
        }
        public void QueryAutoIndexesByAppNameAsync(string sessionTicket, string dataSource, string appName, string xmlAxDocumentIndexQueryData, bool ignoreTimestamp, int startPosition, int pageSize, int maxHits, object userState) {
            if ((this.QueryAutoIndexesByAppNameOperationCompleted == null)) {
                this.QueryAutoIndexesByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryAutoIndexesByAppNameOperationCompleted);
            }
            this.InvokeAsync("QueryAutoIndexesByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        xmlAxDocumentIndexQueryData,
                        ignoreTimestamp,
                        startPosition,
                        pageSize,
                        maxHits}, this.QueryAutoIndexesByAppNameOperationCompleted, userState);
        }
        private void OnQueryAutoIndexesByAppNameOperationCompleted(object arg) {
            if ((this.QueryAutoIndexesByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryAutoIndexesByAppNameCompleted(this, new QueryAutoIndexesByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseAutoIndexResultsByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseAutoIndexResultsByAppId(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseAutoIndexResultsByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseAutoIndexResultsByAppIdAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize) {
            this.BrowseAutoIndexResultsByAppIdAsync(sessionTicket, dataSource, appId, startPosition, pageSize, null);
        }
        public void BrowseAutoIndexResultsByAppIdAsync(string sessionTicket, string dataSource, short appId, int startPosition, int pageSize, object userState) {
            if ((this.BrowseAutoIndexResultsByAppIdOperationCompleted == null)) {
                this.BrowseAutoIndexResultsByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseAutoIndexResultsByAppIdOperationCompleted);
            }
            this.InvokeAsync("BrowseAutoIndexResultsByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId,
                        startPosition,
                        pageSize}, this.BrowseAutoIndexResultsByAppIdOperationCompleted, userState);
        }
        private void OnBrowseAutoIndexResultsByAppIdOperationCompleted(object arg) {
            if ((this.BrowseAutoIndexResultsByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseAutoIndexResultsByAppIdCompleted(this, new BrowseAutoIndexResultsByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/BrowseAutoIndexResultsByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BrowseAutoIndexResultsByAppName(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize) {
            object[] results = this.Invoke("BrowseAutoIndexResultsByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        startPosition,
                        pageSize});
            return ((string)(results[0]));
        }
        public void BrowseAutoIndexResultsByAppNameAsync(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize) {
            this.BrowseAutoIndexResultsByAppNameAsync(sessionTicket, dataSource, appName, startPosition, pageSize, null);
        }
        public void BrowseAutoIndexResultsByAppNameAsync(string sessionTicket, string dataSource, string appName, int startPosition, int pageSize, object userState) {
            if ((this.BrowseAutoIndexResultsByAppNameOperationCompleted == null)) {
                this.BrowseAutoIndexResultsByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBrowseAutoIndexResultsByAppNameOperationCompleted);
            }
            this.InvokeAsync("BrowseAutoIndexResultsByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName,
                        startPosition,
                        pageSize}, this.BrowseAutoIndexResultsByAppNameOperationCompleted, userState);
        }
        private void OnBrowseAutoIndexResultsByAppNameOperationCompleted(object arg) {
            if ((this.BrowseAutoIndexResultsByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BrowseAutoIndexResultsByAppNameCompleted(this, new BrowseAutoIndexResultsByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetCAQConfiguration", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCAQConfiguration(string sessionTicket, string dataSource, int queryId) {
            object[] results = this.Invoke("GetCAQConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        queryId});
            return ((string)(results[0]));
        }
        public void GetCAQConfigurationAsync(string sessionTicket, string dataSource, int queryId) {
            this.GetCAQConfigurationAsync(sessionTicket, dataSource, queryId, null);
        }
        public void GetCAQConfigurationAsync(string sessionTicket, string dataSource, int queryId, object userState) {
            if ((this.GetCAQConfigurationOperationCompleted == null)) {
                this.GetCAQConfigurationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCAQConfigurationOperationCompleted);
            }
            this.InvokeAsync("GetCAQConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        queryId}, this.GetCAQConfigurationOperationCompleted, userState);
        }
        private void OnGetCAQConfigurationOperationCompleted(object arg) {
            if ((this.GetCAQConfigurationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCAQConfigurationCompleted(this, new GetCAQConfigurationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/SaveCAQConfiguration", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SaveCAQConfiguration(string sessionTicket, string dataSource, string queryName, string xmlCaqConfiguration) {
            this.Invoke("SaveCAQConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        queryName,
                        xmlCaqConfiguration});
        }
        public void SaveCAQConfigurationAsync(string sessionTicket, string dataSource, string queryName, string xmlCaqConfiguration) {
            this.SaveCAQConfigurationAsync(sessionTicket, dataSource, queryName, xmlCaqConfiguration, null);
        }
        public void SaveCAQConfigurationAsync(string sessionTicket, string dataSource, string queryName, string xmlCaqConfiguration, object userState) {
            if ((this.SaveCAQConfigurationOperationCompleted == null)) {
                this.SaveCAQConfigurationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveCAQConfigurationOperationCompleted);
            }
            this.InvokeAsync("SaveCAQConfiguration", new object[] {
                        sessionTicket,
                        dataSource,
                        queryName,
                        xmlCaqConfiguration}, this.SaveCAQConfigurationOperationCompleted, userState);
        }
        private void OnSaveCAQConfigurationOperationCompleted(object arg) {
            if ((this.SaveCAQConfigurationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveCAQConfigurationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRubberStampListByAppId", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRubberStampListByAppId(string sessionTicket, string dataSource, short appId) {
            object[] results = this.Invoke("GetRubberStampListByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId});
            return ((string)(results[0]));
        }
        public void GetRubberStampListByAppIdAsync(string sessionTicket, string dataSource, short appId) {
            this.GetRubberStampListByAppIdAsync(sessionTicket, dataSource, appId, null);
        }
        public void GetRubberStampListByAppIdAsync(string sessionTicket, string dataSource, short appId, object userState) {
            if ((this.GetRubberStampListByAppIdOperationCompleted == null)) {
                this.GetRubberStampListByAppIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRubberStampListByAppIdOperationCompleted);
            }
            this.InvokeAsync("GetRubberStampListByAppId", new object[] {
                        sessionTicket,
                        dataSource,
                        appId}, this.GetRubberStampListByAppIdOperationCompleted, userState);
        }
        private void OnGetRubberStampListByAppIdOperationCompleted(object arg) {
            if ((this.GetRubberStampListByAppIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRubberStampListByAppIdCompleted(this, new GetRubberStampListByAppIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRubberStampListByAppName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRubberStampListByAppName(string sessionTicket, string dataSource, string appName) {
            object[] results = this.Invoke("GetRubberStampListByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName});
            return ((string)(results[0]));
        }
        public void GetRubberStampListByAppNameAsync(string sessionTicket, string dataSource, string appName) {
            this.GetRubberStampListByAppNameAsync(sessionTicket, dataSource, appName, null);
        }
        public void GetRubberStampListByAppNameAsync(string sessionTicket, string dataSource, string appName, object userState) {
            if ((this.GetRubberStampListByAppNameOperationCompleted == null)) {
                this.GetRubberStampListByAppNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRubberStampListByAppNameOperationCompleted);
            }
            this.InvokeAsync("GetRubberStampListByAppName", new object[] {
                        sessionTicket,
                        dataSource,
                        appName}, this.GetRubberStampListByAppNameOperationCompleted, userState);
        }
        private void OnGetRubberStampListByAppNameOperationCompleted(object arg) {
            if ((this.GetRubberStampListByAppNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRubberStampListByAppNameCompleted(this, new GetRubberStampListByAppNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFormOverlaysByName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFormOverlaysByName(string sessionTicket, string dataSource, string formName) {
            object[] results = this.Invoke("GetFormOverlaysByName", new object[] {
                        sessionTicket,
                        dataSource,
                        formName});
            return ((string)(results[0]));
        }
        public void GetFormOverlaysByNameAsync(string sessionTicket, string dataSource, string formName) {
            this.GetFormOverlaysByNameAsync(sessionTicket, dataSource, formName, null);
        }
        public void GetFormOverlaysByNameAsync(string sessionTicket, string dataSource, string formName, object userState) {
            if ((this.GetFormOverlaysByNameOperationCompleted == null)) {
                this.GetFormOverlaysByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFormOverlaysByNameOperationCompleted);
            }
            this.InvokeAsync("GetFormOverlaysByName", new object[] {
                        sessionTicket,
                        dataSource,
                        formName}, this.GetFormOverlaysByNameOperationCompleted, userState);
        }
        private void OnGetFormOverlaysByNameOperationCompleted(object arg) {
            if ((this.GetFormOverlaysByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFormOverlaysByNameCompleted(this, new GetFormOverlaysByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFormOverlayByRef", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFormOverlayByRef(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer) {
            object[] results = this.Invoke("GetFormOverlayByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxFormOverlayPointer});
            return ((string)(results[0]));
        }
        public void GetFormOverlayByRefAsync(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer) {
            this.GetFormOverlayByRefAsync(sessionTicket, dataSource, xmlAxFormOverlayPointer, null);
        }
        public void GetFormOverlayByRefAsync(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer, object userState) {
            if ((this.GetFormOverlayByRefOperationCompleted == null)) {
                this.GetFormOverlayByRefOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFormOverlayByRefOperationCompleted);
            }
            this.InvokeAsync("GetFormOverlayByRef", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxFormOverlayPointer}, this.GetFormOverlayByRefOperationCompleted, userState);
        }
        private void OnGetFormOverlayByRefOperationCompleted(object arg) {
            if ((this.GetFormOverlayByRefCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFormOverlayByRefCompleted(this, new GetFormOverlayByRefCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFormOverlayById", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFormOverlayById(string sessionTicket, string dataSource, uint formId) {
            object[] results = this.Invoke("GetFormOverlayById", new object[] {
                        sessionTicket,
                        dataSource,
                        formId});
            return ((string)(results[0]));
        }
        public void GetFormOverlayByIdAsync(string sessionTicket, string dataSource, uint formId) {
            this.GetFormOverlayByIdAsync(sessionTicket, dataSource, formId, null);
        }
        public void GetFormOverlayByIdAsync(string sessionTicket, string dataSource, uint formId, object userState) {
            if ((this.GetFormOverlayByIdOperationCompleted == null)) {
                this.GetFormOverlayByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFormOverlayByIdOperationCompleted);
            }
            this.InvokeAsync("GetFormOverlayById", new object[] {
                        sessionTicket,
                        dataSource,
                        formId}, this.GetFormOverlayByIdOperationCompleted, userState);
        }
        private void OnGetFormOverlayByIdOperationCompleted(object arg) {
            if ((this.GetFormOverlayByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFormOverlayByIdCompleted(this, new GetFormOverlayByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetImageFile", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetImageFile(string sessionTicket, string xmlImageFileData) {
            object[] results = this.Invoke("GetImageFile", new object[] {
                        sessionTicket,
                        xmlImageFileData});
            return ((string)(results[0]));
        }
        public void GetImageFileAsync(string sessionTicket, string xmlImageFileData) {
            this.GetImageFileAsync(sessionTicket, xmlImageFileData, null);
        }
        public void GetImageFileAsync(string sessionTicket, string xmlImageFileData, object userState) {
            if ((this.GetImageFileOperationCompleted == null)) {
                this.GetImageFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageFileOperationCompleted);
            }
            this.InvokeAsync("GetImageFile", new object[] {
                        sessionTicket,
                        xmlImageFileData}, this.GetImageFileOperationCompleted, userState);
        }
        private void OnGetImageFileOperationCompleted(object arg) {
            if ((this.GetImageFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageFileCompleted(this, new GetImageFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetImageStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetImageStream(string sessionTicket, string xmlImageFileData, string xmlImageStreamData) {
            object[] results = this.Invoke("GetImageStream", new object[] {
                        sessionTicket,
                        xmlImageFileData,
                        xmlImageStreamData});
            return ((string)(results[0]));
        }
        public void GetImageStreamAsync(string sessionTicket, string xmlImageFileData, string xmlImageStreamData) {
            this.GetImageStreamAsync(sessionTicket, xmlImageFileData, xmlImageStreamData, null);
        }
        public void GetImageStreamAsync(string sessionTicket, string xmlImageFileData, string xmlImageStreamData, object userState) {
            if ((this.GetImageStreamOperationCompleted == null)) {
                this.GetImageStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageStreamOperationCompleted);
            }
            this.InvokeAsync("GetImageStream", new object[] {
                        sessionTicket,
                        xmlImageFileData,
                        xmlImageStreamData}, this.GetImageStreamOperationCompleted, userState);
        }
        private void OnGetImageStreamOperationCompleted(object arg) {
            if ((this.GetImageStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageStreamCompleted(this, new GetImageStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRubberStampFile", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRubberStampFile(string sessionTicket, string dataSource, string xmlAxRubberStamp) {
            object[] results = this.Invoke("GetRubberStampFile", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxRubberStamp});
            return ((string)(results[0]));
        }
        public void GetRubberStampFileAsync(string sessionTicket, string dataSource, string xmlAxRubberStamp) {
            this.GetRubberStampFileAsync(sessionTicket, dataSource, xmlAxRubberStamp, null);
        }
        public void GetRubberStampFileAsync(string sessionTicket, string dataSource, string xmlAxRubberStamp, object userState) {
            if ((this.GetRubberStampFileOperationCompleted == null)) {
                this.GetRubberStampFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRubberStampFileOperationCompleted);
            }
            this.InvokeAsync("GetRubberStampFile", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxRubberStamp}, this.GetRubberStampFileOperationCompleted, userState);
        }
        private void OnGetRubberStampFileOperationCompleted(object arg) {
            if ((this.GetRubberStampFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRubberStampFileCompleted(this, new GetRubberStampFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFormOverlayFileByName", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFormOverlayFileByName(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer) {
            object[] results = this.Invoke("GetFormOverlayFileByName", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxFormOverlayPointer});
            return ((string)(results[0]));
        }
        public void GetFormOverlayFileByNameAsync(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer) {
            this.GetFormOverlayFileByNameAsync(sessionTicket, dataSource, xmlAxFormOverlayPointer, null);
        }
        public void GetFormOverlayFileByNameAsync(string sessionTicket, string dataSource, string xmlAxFormOverlayPointer, object userState) {
            if ((this.GetFormOverlayFileByNameOperationCompleted == null)) {
                this.GetFormOverlayFileByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFormOverlayFileByNameOperationCompleted);
            }
            this.InvokeAsync("GetFormOverlayFileByName", new object[] {
                        sessionTicket,
                        dataSource,
                        xmlAxFormOverlayPointer}, this.GetFormOverlayFileByNameOperationCompleted, userState);
        }
        private void OnGetFormOverlayFileByNameOperationCompleted(object arg) {
            if ((this.GetFormOverlayFileByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFormOverlayFileByNameCompleted(this, new GetFormOverlayFileByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetFormOverlayFileById", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFormOverlayFileById(string sessionTicket, string dataSource, uint formId) {
            object[] results = this.Invoke("GetFormOverlayFileById", new object[] {
                        sessionTicket,
                        dataSource,
                        formId});
            return ((string)(results[0]));
        }
        public void GetFormOverlayFileByIdAsync(string sessionTicket, string dataSource, uint formId) {
            this.GetFormOverlayFileByIdAsync(sessionTicket, dataSource, formId, null);
        }
        public void GetFormOverlayFileByIdAsync(string sessionTicket, string dataSource, uint formId, object userState) {
            if ((this.GetFormOverlayFileByIdOperationCompleted == null)) {
                this.GetFormOverlayFileByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFormOverlayFileByIdOperationCompleted);
            }
            this.InvokeAsync("GetFormOverlayFileById", new object[] {
                        sessionTicket,
                        dataSource,
                        formId}, this.GetFormOverlayFileByIdOperationCompleted, userState);
        }
        private void OnGetFormOverlayFileByIdOperationCompleted(object arg) {
            if ((this.GetFormOverlayFileByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFormOverlayFileByIdCompleted(this, new GetFormOverlayFileByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/AddPageVersion", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddPageVersion(string sessionTicket, string pageRef, string xmlAxVersionUploadData) {
            object[] results = this.Invoke("AddPageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        xmlAxVersionUploadData});
            return ((string)(results[0]));
        }
        public void AddPageVersionAsync(string sessionTicket, string pageRef, string xmlAxVersionUploadData) {
            this.AddPageVersionAsync(sessionTicket, pageRef, xmlAxVersionUploadData, null);
        }
        public void AddPageVersionAsync(string sessionTicket, string pageRef, string xmlAxVersionUploadData, object userState) {
            if ((this.AddPageVersionOperationCompleted == null)) {
                this.AddPageVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddPageVersionOperationCompleted);
            }
            this.InvokeAsync("AddPageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        xmlAxVersionUploadData}, this.AddPageVersionOperationCompleted, userState);
        }
        private void OnAddPageVersionOperationCompleted(object arg) {
            if ((this.AddPageVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddPageVersionCompleted(this, new AddPageVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/AddPageVersionFromStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddPageVersionFromStream(string sessionTicket, string pageRef, string xmlAxVersionUploadData, string xmlAxStreamData) {
            object[] results = this.Invoke("AddPageVersionFromStream", new object[] {
                        sessionTicket,
                        pageRef,
                        xmlAxVersionUploadData,
                        xmlAxStreamData});
            return ((string)(results[0]));
        }
        public void AddPageVersionFromStreamAsync(string sessionTicket, string pageRef, string xmlAxVersionUploadData, string xmlAxStreamData) {
            this.AddPageVersionFromStreamAsync(sessionTicket, pageRef, xmlAxVersionUploadData, xmlAxStreamData, null);
        }
        public void AddPageVersionFromStreamAsync(string sessionTicket, string pageRef, string xmlAxVersionUploadData, string xmlAxStreamData, object userState) {
            if ((this.AddPageVersionFromStreamOperationCompleted == null)) {
                this.AddPageVersionFromStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddPageVersionFromStreamOperationCompleted);
            }
            this.InvokeAsync("AddPageVersionFromStream", new object[] {
                        sessionTicket,
                        pageRef,
                        xmlAxVersionUploadData,
                        xmlAxStreamData}, this.AddPageVersionFromStreamOperationCompleted, userState);
        }
        private void OnAddPageVersionFromStreamOperationCompleted(object arg) {
            if ((this.AddPageVersionFromStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddPageVersionFromStreamCompleted(this, new AddPageVersionFromStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/RenderPageVersion", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RenderPageVersion(string sessionTicket, string xmlRenderData) {
            object[] results = this.Invoke("RenderPageVersion", new object[] {
                        sessionTicket,
                        xmlRenderData});
            return ((string)(results[0]));
        }
        public void RenderPageVersionAsync(string sessionTicket, string xmlRenderData) {
            this.RenderPageVersionAsync(sessionTicket, xmlRenderData, null);
        }
        public void RenderPageVersionAsync(string sessionTicket, string xmlRenderData, object userState) {
            if ((this.RenderPageVersionOperationCompleted == null)) {
                this.RenderPageVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRenderPageVersionOperationCompleted);
            }
            this.InvokeAsync("RenderPageVersion", new object[] {
                        sessionTicket,
                        xmlRenderData}, this.RenderPageVersionOperationCompleted, userState);
        }
        private void OnRenderPageVersionOperationCompleted(object arg) {
            if ((this.RenderPageVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RenderPageVersionCompleted(this, new RenderPageVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.WebMethodAttribute(MessageName="RenderPageVersionAsync1")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/RenderPageVersionAsync", RequestElementName="RenderPageVersionAsync", RequestNamespace="http://documentum.com/AX/WebServices", ResponseElementName="RenderPageVersionAsyncResponse", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("RenderPageVersionAsyncResult")]
        public string RenderPageVersionAsync1(string sessionTicket, string xmlRenderData) {
            object[] results = this.Invoke("RenderPageVersionAsync1", new object[] {
                        sessionTicket,
                        xmlRenderData});
            return ((string)(results[0]));
        }
        public void RenderPageVersionAsync1Async(string sessionTicket, string xmlRenderData) {
            this.RenderPageVersionAsync1Async(sessionTicket, xmlRenderData, null);
        }
        public void RenderPageVersionAsync1Async(string sessionTicket, string xmlRenderData, object userState) {
            if ((this.RenderPageVersionAsync1OperationCompleted == null)) {
                this.RenderPageVersionAsync1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnRenderPageVersionAsync1OperationCompleted);
            }
            this.InvokeAsync("RenderPageVersionAsync1", new object[] {
                        sessionTicket,
                        xmlRenderData}, this.RenderPageVersionAsync1OperationCompleted, userState);
        }
        private void OnRenderPageVersionAsync1OperationCompleted(object arg) {
            if ((this.RenderPageVersionAsync1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RenderPageVersionAsync1Completed(this, new RenderPageVersionAsync1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRenderingStatus", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRenderingStatus(string sessionTicket, string key, string xmlRenderData) {
            object[] results = this.Invoke("GetRenderingStatus", new object[] {
                        sessionTicket,
                        key,
                        xmlRenderData});
            return ((string)(results[0]));
        }
        public void GetRenderingStatusAsync(string sessionTicket, string key, string xmlRenderData) {
            this.GetRenderingStatusAsync(sessionTicket, key, xmlRenderData, null);
        }
        public void GetRenderingStatusAsync(string sessionTicket, string key, string xmlRenderData, object userState) {
            if ((this.GetRenderingStatusOperationCompleted == null)) {
                this.GetRenderingStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRenderingStatusOperationCompleted);
            }
            this.InvokeAsync("GetRenderingStatus", new object[] {
                        sessionTicket,
                        key,
                        xmlRenderData}, this.GetRenderingStatusOperationCompleted, userState);
        }
        private void OnGetRenderingStatusOperationCompleted(object arg) {
            if ((this.GetRenderingStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRenderingStatusCompleted(this, new GetRenderingStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/GetRenderImageStream", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetRenderImageStream(string sessionTicket, string key, string xmlRenderData, string xmlImageStreamData) {
            object[] results = this.Invoke("GetRenderImageStream", new object[] {
                        sessionTicket,
                        key,
                        xmlRenderData,
                        xmlImageStreamData});
            return ((string)(results[0]));
        }
        public void GetRenderImageStreamAsync(string sessionTicket, string key, string xmlRenderData, string xmlImageStreamData) {
            this.GetRenderImageStreamAsync(sessionTicket, key, xmlRenderData, xmlImageStreamData, null);
        }
        public void GetRenderImageStreamAsync(string sessionTicket, string key, string xmlRenderData, string xmlImageStreamData, object userState) {
            if ((this.GetRenderImageStreamOperationCompleted == null)) {
                this.GetRenderImageStreamOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRenderImageStreamOperationCompleted);
            }
            this.InvokeAsync("GetRenderImageStream", new object[] {
                        sessionTicket,
                        key,
                        xmlRenderData,
                        xmlImageStreamData}, this.GetRenderImageStreamOperationCompleted, userState);
        }
        private void OnGetRenderImageStreamOperationCompleted(object arg) {
            if ((this.GetRenderImageStreamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRenderImageStreamCompleted(this, new GetRenderImageStreamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/DeletePageVersion", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeletePageVersion(string sessionTicket, string pageRef, short version) {
            object[] results = this.Invoke("DeletePageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        version});
            return ((string)(results[0]));
        }
        public void DeletePageVersionAsync(string sessionTicket, string pageRef, short version) {
            this.DeletePageVersionAsync(sessionTicket, pageRef, version, null);
        }
        public void DeletePageVersionAsync(string sessionTicket, string pageRef, short version, object userState) {
            if ((this.DeletePageVersionOperationCompleted == null)) {
                this.DeletePageVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletePageVersionOperationCompleted);
            }
            this.InvokeAsync("DeletePageVersion", new object[] {
                        sessionTicket,
                        pageRef,
                        version}, this.DeletePageVersionOperationCompleted, userState);
        }
        private void OnDeletePageVersionOperationCompleted(object arg) {
            if ((this.DeletePageVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletePageVersionCompleted(this, new DeletePageVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        [System.Web.Services.Protocols.SoapHeaderAttribute("AxSoapAlertsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://documentum.com/AX/WebServices/UpdateAnnotationFile", RequestNamespace="http://documentum.com/AX/WebServices", ResponseNamespace="http://documentum.com/AX/WebServices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateAnnotationFile(string sessionTicket, string pageRef, short version, string filePath) {
            object[] results = this.Invoke("UpdateAnnotationFile", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        filePath});
            return ((string)(results[0]));
        }
        public void UpdateAnnotationFileAsync(string sessionTicket, string pageRef, short version, string filePath) {
            this.UpdateAnnotationFileAsync(sessionTicket, pageRef, version, filePath, null);
        }
        public void UpdateAnnotationFileAsync(string sessionTicket, string pageRef, short version, string filePath, object userState) {
            if ((this.UpdateAnnotationFileOperationCompleted == null)) {
                this.UpdateAnnotationFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateAnnotationFileOperationCompleted);
            }
            this.InvokeAsync("UpdateAnnotationFile", new object[] {
                        sessionTicket,
                        pageRef,
                        version,
                        filePath}, this.UpdateAnnotationFileOperationCompleted, userState);
        }
        private void OnUpdateAnnotationFileOperationCompleted(object arg) {
            if ((this.UpdateAnnotationFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateAnnotationFileCompleted(this, new UpdateAnnotationFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://documentum.com/AX/WebServices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://documentum.com/AX/WebServices", IsNullable=false)]
    public partial class AxWinCode : System.Web.Services.Protocols.SoapHeader {
        private string keyIdField;
        private byte[] codeField;
        private System.Xml.XmlAttribute[] anyAttrField;
        public string KeyId {
            get {
                return this.keyIdField;
            }
            set {
                this.keyIdField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://documentum.com/AX/WebServices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://documentum.com/AX/WebServices", IsNullable=false)]
    public partial class AxSoapAlerts : System.Web.Services.Protocols.SoapHeader {
        private int alertFlagsField;
        private string messageField;
        private int parameterField;
        private System.Xml.XmlAttribute[] anyAttrField;
        public int AlertFlags {
            get {
                return this.alertFlagsField;
            }
            set {
                this.alertFlagsField = value;
            }
        }
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        public int Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UpdateAnnotationFromStreamCompletedEventHandler(object sender, UpdateAnnotationFromStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateAnnotationFromStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UpdateAnnotationFromStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDigitalSignatureHistoryCompletedEventHandler(object sender, GetDigitalSignatureHistoryCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDigitalSignatureHistoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDigitalSignatureHistoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SignPageVersionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFileInfoCompletedEventHandler(object sender, GetFileInfoCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFileInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFileInfoByDocRefCompletedEventHandler(object sender, GetFileInfoByDocRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileInfoByDocRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFileInfoByDocRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetCertificatesCompletedEventHandler(object sender, GetCertificatesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCertificatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetCertificatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryDocumentIndexesCompletedEventHandler(object sender, QueryDocumentIndexesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryDocumentIndexesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryDocumentIndexesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryDocumentIndexesByRefCompletedEventHandler(object sender, QueryDocumentIndexesByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryDocumentIndexesByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryDocumentIndexesByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseDocumentIndexResultsCompletedEventHandler(object sender, BrowseDocumentIndexResultsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseDocumentIndexResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseDocumentIndexResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseDocumentIndexResultsByRefCompletedEventHandler(object sender, BrowseDocumentIndexResultsByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseDocumentIndexResultsByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseDocumentIndexResultsByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ApplyAutoIndexByAppIdCompletedEventHandler(object sender, ApplyAutoIndexByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ApplyAutoIndexByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ApplyAutoIndexByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ApplyAutoIndexCompletedEventHandler(object sender, ApplyAutoIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ApplyAutoIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ApplyAutoIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ApplyAutoIndexByRefCompletedEventHandler(object sender, ApplyAutoIndexByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ApplyAutoIndexByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ApplyAutoIndexByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LookupKeyReferenceByAppIdCompletedEventHandler(object sender, LookupKeyReferenceByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LookupKeyReferenceByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LookupKeyReferenceByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LookupKeyReferenceCompletedEventHandler(object sender, LookupKeyReferenceCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LookupKeyReferenceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LookupKeyReferenceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LookupKeyReferenceByRefCompletedEventHandler(object sender, LookupKeyReferenceByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LookupKeyReferenceByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LookupKeyReferenceByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ModifyDocumentIndexCompletedEventHandler(object sender, ModifyDocumentIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ModifyDocumentIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ModifyDocumentIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ModifyDocumentIndexByRefCompletedEventHandler(object sender, ModifyDocumentIndexByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ModifyDocumentIndexByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ModifyDocumentIndexByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentIndexCompletedEventHandler(object sender, DeleteDocumentIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentIndexByRefCompletedEventHandler(object sender, DeleteDocumentIndexByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentIndexByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentIndexByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteAutoIndexCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteAutoIndexByAppNameCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveDocumentIndexCompletedEventHandler(object sender, SaveDocumentIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveDocumentIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SaveDocumentIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveDocumentIndexByRefCompletedEventHandler(object sender, SaveDocumentIndexByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveDocumentIndexByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SaveDocumentIndexByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentIndexCompletedEventHandler(object sender, GetDocumentIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentIndexForEditCompletedEventHandler(object sender, GetDocumentIndexForEditCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentIndexForEditCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentIndexForEditCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveAndReturnDocumentIndexCompletedEventHandler(object sender, SaveAndReturnDocumentIndexCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveAndReturnDocumentIndexCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SaveAndReturnDocumentIndexCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveAndReturnDocumentIndexByRefCompletedEventHandler(object sender, SaveAndReturnDocumentIndexByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveAndReturnDocumentIndexByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SaveAndReturnDocumentIndexByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SubmitFullTextJobCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SubmitFullTextJobByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextJobQueueListCompletedEventHandler(object sender, GetFullTextJobQueueListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextJobQueueListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextJobQueueListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextJobListCompletedEventHandler(object sender, GetFullTextJobListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextJobListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextJobListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextHitCountCompletedEventHandler(object sender, GetFullTextHitCountCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextHitCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextHitCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextHitCountByRefCompletedEventHandler(object sender, GetFullTextHitCountByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextHitCountByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextHitCountByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextHitInfoCompletedEventHandler(object sender, GetFullTextHitInfoCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextHitInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextHitInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFullTextHitInfoByRefCompletedEventHandler(object sender, GetFullTextHitInfoByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFullTextHitInfoByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFullTextHitInfoByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void OpenBatchDocumentByRefCompletedEventHandler(object sender, OpenBatchDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OpenBatchDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal OpenBatchDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CloseBatchDocumentByRefCompletedEventHandler(object sender, CloseBatchDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CloseBatchDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CloseBatchDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LockBatchDocumentByRefCompletedEventHandler(object sender, LockBatchDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LockBatchDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LockBatchDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UnlockBatchDocumentCompletedEventHandler(object sender, UnlockBatchDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnlockBatchDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UnlockBatchDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UnlockBatchDocumentsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetBatchDocumentListByAppIdCompletedEventHandler(object sender, GetBatchDocumentListByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBatchDocumentListByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetBatchDocumentListByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetBatchDocumentListByAppNameCompletedEventHandler(object sender, GetBatchDocumentListByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBatchDocumentListByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetBatchDocumentListByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteBatchDocumentByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteBatchDocumentsByRefCompletedEventHandler(object sender, DeleteBatchDocumentsByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteBatchDocumentsByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteBatchDocumentsByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ChangeBatchNameByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ChangeBatchMemoByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetBatchMemoByRefCompletedEventHandler(object sender, GetBatchMemoByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBatchMemoByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetBatchMemoByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CreateDocumentFromBatchPageByRefCompletedEventHandler(object sender, CreateDocumentFromBatchPageByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateDocumentFromBatchPageByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CreateDocumentFromBatchPageByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AttachBatchPagesByRefCompletedEventHandler(object sender, AttachBatchPagesByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AttachBatchPagesByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal AttachBatchPagesByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CreateBatchPageCompletedEventHandler(object sender, CreateBatchPageCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateBatchPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CreateBatchPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CreateBatchPageByRefCompletedEventHandler(object sender, CreateBatchPageByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateBatchPageByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CreateBatchPageByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetBatchPageListByRefCompletedEventHandler(object sender, GetBatchPageListByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBatchPageListByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetBatchPageListByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteBatchPagesCompletedEventHandler(object sender, DeleteBatchPagesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteBatchPagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteBatchPagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DownloadImageStreamCompletedEventHandler(object sender, DownloadImageStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DownloadImageStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DownloadImageStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UploadImageStreamCompletedEventHandler(object sender, UploadImageStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadImageStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UploadImageStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetJobQueueListCompletedEventHandler(object sender, GetJobQueueListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJobQueueListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetJobQueueListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetJobListCompletedEventHandler(object sender, GetJobListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJobListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetJobListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetJobElementListCompletedEventHandler(object sender, GetJobElementListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetJobElementListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetJobElementListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ResubmitJobsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteJobsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFAMJobStatusCompletedEventHandler(object sender, GetFAMJobStatusCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFAMJobStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFAMJobStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFAMJobErrorMsgCompletedEventHandler(object sender, GetFAMJobErrorMsgCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFAMJobErrorMsgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFAMJobErrorMsgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LogAuditEventCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetHookMessageCompletedEventHandler(object sender, GetHookMessageCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetHookMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetHookMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SecuredLoginCompletedEventHandler(object sender, SecuredLoginCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SecuredLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SecuredLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void WindowsLoginCompletedEventHandler(object sender, WindowsLoginCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WindowsLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal WindowsLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LoginSetCompletedEventHandler(object sender, LoginSetCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginSetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LoginSetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LogoutCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetEncryptionKeyCompletedEventHandler(object sender, GetEncryptionKeyCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEncryptionKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetEncryptionKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        public string key {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryUserSessionsCompletedEventHandler(object sender, QueryUserSessionsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryUserSessionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryUserSessionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseUserSessionResultsCompletedEventHandler(object sender, BrowseUserSessionResultsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseUserSessionResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseUserSessionResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void KillUserSessionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDataSourceNameListCompletedEventHandler(object sender, GetDataSourceNameListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataSourceNameListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDataSourceNameListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetLoggedOnDataSourceNameListCompletedEventHandler(object sender, GetLoggedOnDataSourceNameListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLoggedOnDataSourceNameListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetLoggedOnDataSourceNameListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationListCompletedEventHandler(object sender, GetApplicationListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ChangePasswordCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SecuredChangePasswordCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUserPermissionsCompletedEventHandler(object sender, GetUserPermissionsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserPermissionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetUserPermissionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetPermissionsDefinitionCompletedEventHandler(object sender, GetPermissionsDefinitionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPermissionsDefinitionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetPermissionsDefinitionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetLicenseInfoCompletedEventHandler(object sender, GetLicenseInfoCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLicenseInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetLicenseInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetSessionTimeoutCompletedEventHandler(object sender, GetSessionTimeoutCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSessionTimeoutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetSessionTimeoutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetSessionFeaturesCompletedEventHandler(object sender, GetSessionFeaturesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSessionFeaturesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetSessionFeaturesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetWorkflowProviderCompletedEventHandler(object sender, GetWorkflowProviderCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWorkflowProviderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetWorkflowProviderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAnnGroupSecurityMgrCompletedEventHandler(object sender, GetAnnGroupSecurityMgrCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAnnGroupSecurityMgrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetAnnGroupSecurityMgrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetIrmMembersCompletedEventHandler(object sender, GetIrmMembersCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIrmMembersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetIrmMembersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAxViewerLicenseCompletedEventHandler(object sender, GetAxViewerLicenseCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAxViewerLicenseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetAxViewerLicenseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        public string key {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        public byte[] sessionSignature {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[2]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAxUsersCompletedEventHandler(object sender, GetAxUsersCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAxUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetAxUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationFieldsCompletedEventHandler(object sender, GetApplicationFieldsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationFieldsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationFieldsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetODMAFieldsCompletedEventHandler(object sender, GetODMAFieldsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetODMAFieldsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetODMAFieldsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetReportFieldsCompletedEventHandler(object sender, GetReportFieldsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetReportFieldsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetReportFieldsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationQueriesCompletedEventHandler(object sender, GetApplicationQueriesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationQueriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationQueriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetCAQQueriesCompletedEventHandler(object sender, GetCAQQueriesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCAQQueriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetCAQQueriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationsDataCompletedEventHandler(object sender, GetApplicationsDataCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationsDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationsDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRetentionProviderCompletedEventHandler(object sender, GetRetentionProviderCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRetentionProviderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRetentionProviderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationsHoldLabelsCompletedEventHandler(object sender, GetApplicationsHoldLabelsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationsHoldLabelsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationsHoldLabelsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocIdsWithHoldLabelCompletedEventHandler(object sender, GetDocIdsWithHoldLabelCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocIdsWithHoldLabelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocIdsWithHoldLabelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRetentionConfigurationCompletedEventHandler(object sender, GetRetentionConfigurationCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRetentionConfigurationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRetentionConfigurationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetApplicationBusinessProcessListCompletedEventHandler(object sender, GetApplicationBusinessProcessListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApplicationBusinessProcessListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetApplicationBusinessProcessListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void OpenDocumentCompletedEventHandler(object sender, OpenDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OpenDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal OpenDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void OpenDocumentByRefCompletedEventHandler(object sender, OpenDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OpenDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal OpenDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CloseDocumentCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CloseDocumentByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CreateNewDocumentCompletedEventHandler(object sender, CreateNewDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateNewDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CreateNewDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckOutDocumentCompletedEventHandler(object sender, CheckOutDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckOutDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CheckOutDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckOutDocumentByRefCompletedEventHandler(object sender, CheckOutDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckOutDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CheckOutDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckInDocumentCompletedEventHandler(object sender, CheckInDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckInDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CheckInDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckInDocumentByRefCompletedEventHandler(object sender, CheckInDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckInDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CheckInDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CancelCheckOutDocumentCompletedEventHandler(object sender, CancelCheckOutDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CancelCheckOutDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CancelCheckOutDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CancelCheckOutDocumentByRefCompletedEventHandler(object sender, CancelCheckOutDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CancelCheckOutDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CancelCheckOutDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LockDocumentCompletedEventHandler(object sender, LockDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LockDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LockDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LockDocumentByRefCompletedEventHandler(object sender, LockDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LockDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal LockDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UnlockDocumentCompletedEventHandler(object sender, UnlockDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnlockDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UnlockDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UnlockDocumentByRefCompletedEventHandler(object sender, UnlockDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnlockDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UnlockDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UnlockDocumentsByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentCompletedEventHandler(object sender, DeleteDocumentCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentByRefCompletedEventHandler(object sender, DeleteDocumentByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentsCompletedEventHandler(object sender, DeleteDocumentsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentsByRefCompletedEventHandler(object sender, DeleteDocumentsByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentsByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentsByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentPageListCompletedEventHandler(object sender, GetDocumentPageListCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentPageListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentPageListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentPageListByRefCompletedEventHandler(object sender, GetDocumentPageListByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentPageListByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentPageListByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UploadDocumentPageCompletedEventHandler(object sender, UploadDocumentPageCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadDocumentPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UploadDocumentPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UploadDocumentPageByRefCompletedEventHandler(object sender, UploadDocumentPageByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadDocumentPageByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UploadDocumentPageByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UploadDocumentPageStreamByRefCompletedEventHandler(object sender, UploadDocumentPageStreamByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadDocumentPageStreamByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UploadDocumentPageStreamByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentPageCompletedEventHandler(object sender, DeleteDocumentPageCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentPageByRefCompletedEventHandler(object sender, DeleteDocumentPageByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentPageByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentPageByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryCheckedOutDocumentsCompletedEventHandler(object sender, QueryCheckedOutDocumentsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryCheckedOutDocumentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryCheckedOutDocumentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseCheckedOutDocumentResultsCompletedEventHandler(object sender, BrowseCheckedOutDocumentResultsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseCheckedOutDocumentResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseCheckedOutDocumentResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryLockedDocumentsCompletedEventHandler(object sender, QueryLockedDocumentsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryLockedDocumentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryLockedDocumentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseLockedDocumentResultsCompletedEventHandler(object sender, BrowseLockedDocumentResultsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseLockedDocumentResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseLockedDocumentResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentPropertyCompletedEventHandler(object sender, GetDocumentPropertyCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentPropertyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentPropertyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentPropertyByRefCompletedEventHandler(object sender, GetDocumentPropertyByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentPropertyByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentPropertyByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SetDocumentPropertyCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SetDocumentPropertyByRefCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentRevisionsCompletedEventHandler(object sender, GetDocumentRevisionsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentRevisionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentRevisionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentRevisionsByRefCompletedEventHandler(object sender, GetDocumentRevisionsByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentRevisionsByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentRevisionsByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentRevisionCompletedEventHandler(object sender, DeleteDocumentRevisionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentRevisionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentRevisionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteDocumentRevisionByRefCompletedEventHandler(object sender, DeleteDocumentRevisionByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDocumentRevisionByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeleteDocumentRevisionByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void MergePDFPagesCompletedEventHandler(object sender, MergePDFPagesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MergePDFPagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal MergePDFPagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void MergePDFPagesByRefCompletedEventHandler(object sender, MergePDFPagesByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MergePDFPagesByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal MergePDFPagesByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ExportDocumentPagesCompletedEventHandler(object sender, ExportDocumentPagesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExportDocumentPagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ExportDocumentPagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ExportDocumentPagesByRefCompletedEventHandler(object sender, ExportDocumentPagesByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExportDocumentPagesByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal ExportDocumentPagesByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetExportDocumentPagesResultCompletedEventHandler(object sender, GetExportDocumentPagesResultCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExportDocumentPagesResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetExportDocumentPagesResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentDisplayUrlByRefCompletedEventHandler(object sender, GetDocumentDisplayUrlByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentDisplayUrlByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentDisplayUrlByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentDisplayUrlCompletedEventHandler(object sender, GetDocumentDisplayUrlCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentDisplayUrlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentDisplayUrlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ReleaseDocumentsLockCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void MoveDocumentPageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CreateBatchFromDocumentPagesCompletedEventHandler(object sender, CreateBatchFromDocumentPagesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateBatchFromDocumentPagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal CreateBatchFromDocumentPagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SetDocumentRetentionCompletedEventHandler(object sender, SetDocumentRetentionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetDocumentRetentionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SetDocumentRetentionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SetDocumentRetentionHoldCompletedEventHandler(object sender, SetDocumentRetentionHoldCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetDocumentRetentionHoldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal SetDocumentRetentionHoldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentHoldLabelCompletedEventHandler(object sender, GetDocumentHoldLabelCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentHoldLabelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentHoldLabelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RemoveDocumentRetentionHoldCompletedEventHandler(object sender, RemoveDocumentRetentionHoldCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RemoveDocumentRetentionHoldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal RemoveDocumentRetentionHoldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentRetentionStartDateAsFiletimeCompletedEventHandler(object sender, GetDocumentRetentionStartDateAsFiletimeCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentRetentionStartDateAsFiletimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentRetentionStartDateAsFiletimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetDocumentRetentionEndDateAsFiletimeCompletedEventHandler(object sender, GetDocumentRetentionEndDateAsFiletimeCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentRetentionEndDateAsFiletimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetDocumentRetentionEndDateAsFiletimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void StartBusinessProcessOnDocumentCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetIrmPolicyTemplatesCompletedEventHandler(object sender, GetIrmPolicyTemplatesCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIrmPolicyTemplatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetIrmPolicyTemplatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryDocumentsCompletedEventHandler(object sender, QueryDocumentsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryDocumentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryDocumentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseDocumentResultsCompletedEventHandler(object sender, BrowseDocumentResultsCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseDocumentResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseDocumentResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveQueryCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteQueryCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryApplicationIndexesByAppIdCompletedEventHandler(object sender, QueryApplicationIndexesByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryApplicationIndexesByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryApplicationIndexesByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryApplicationIndexesByAppNameCompletedEventHandler(object sender, QueryApplicationIndexesByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryApplicationIndexesByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryApplicationIndexesByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RequeryApplicationIndexesByAppIdCompletedEventHandler(object sender, RequeryApplicationIndexesByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequeryApplicationIndexesByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal RequeryApplicationIndexesByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RequeryApplicationIndexesByAppNameCompletedEventHandler(object sender, RequeryApplicationIndexesByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequeryApplicationIndexesByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal RequeryApplicationIndexesByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseApplicationIndexResultsByAppIdCompletedEventHandler(object sender, BrowseApplicationIndexResultsByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseApplicationIndexResultsByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseApplicationIndexResultsByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseApplicationIndexResultsByAppNameCompletedEventHandler(object sender, BrowseApplicationIndexResultsByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseApplicationIndexResultsByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseApplicationIndexResultsByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryAutoIndexesByAppIdCompletedEventHandler(object sender, QueryAutoIndexesByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryAutoIndexesByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryAutoIndexesByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void QueryAutoIndexesByAppNameCompletedEventHandler(object sender, QueryAutoIndexesByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryAutoIndexesByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal QueryAutoIndexesByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseAutoIndexResultsByAppIdCompletedEventHandler(object sender, BrowseAutoIndexResultsByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseAutoIndexResultsByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseAutoIndexResultsByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BrowseAutoIndexResultsByAppNameCompletedEventHandler(object sender, BrowseAutoIndexResultsByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowseAutoIndexResultsByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal BrowseAutoIndexResultsByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetCAQConfigurationCompletedEventHandler(object sender, GetCAQConfigurationCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCAQConfigurationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetCAQConfigurationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SaveCAQConfigurationCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRubberStampListByAppIdCompletedEventHandler(object sender, GetRubberStampListByAppIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRubberStampListByAppIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRubberStampListByAppIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRubberStampListByAppNameCompletedEventHandler(object sender, GetRubberStampListByAppNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRubberStampListByAppNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRubberStampListByAppNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFormOverlaysByNameCompletedEventHandler(object sender, GetFormOverlaysByNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFormOverlaysByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFormOverlaysByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFormOverlayByRefCompletedEventHandler(object sender, GetFormOverlayByRefCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFormOverlayByRefCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFormOverlayByRefCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFormOverlayByIdCompletedEventHandler(object sender, GetFormOverlayByIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFormOverlayByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFormOverlayByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetImageFileCompletedEventHandler(object sender, GetImageFileCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetImageFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetImageStreamCompletedEventHandler(object sender, GetImageStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetImageStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRubberStampFileCompletedEventHandler(object sender, GetRubberStampFileCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRubberStampFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRubberStampFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFormOverlayFileByNameCompletedEventHandler(object sender, GetFormOverlayFileByNameCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFormOverlayFileByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFormOverlayFileByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetFormOverlayFileByIdCompletedEventHandler(object sender, GetFormOverlayFileByIdCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFormOverlayFileByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetFormOverlayFileByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddPageVersionCompletedEventHandler(object sender, AddPageVersionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddPageVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal AddPageVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddPageVersionFromStreamCompletedEventHandler(object sender, AddPageVersionFromStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddPageVersionFromStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal AddPageVersionFromStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RenderPageVersionCompletedEventHandler(object sender, RenderPageVersionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RenderPageVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal RenderPageVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RenderPageVersionAsync1CompletedEventHandler(object sender, RenderPageVersionAsync1CompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RenderPageVersionAsync1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal RenderPageVersionAsync1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRenderingStatusCompletedEventHandler(object sender, GetRenderingStatusCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRenderingStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRenderingStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetRenderImageStreamCompletedEventHandler(object sender, GetRenderImageStreamCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRenderImageStreamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal GetRenderImageStreamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeletePageVersionCompletedEventHandler(object sender, DeletePageVersionCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeletePageVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal DeletePageVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UpdateAnnotationFileCompletedEventHandler(object sender, UpdateAnnotationFileCompletedEventArgs e);
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateAnnotationFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        private object[] results;
        internal UpdateAnnotationFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
#pragma warning restore 1591