//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _hosting_web_task {
    
    
    // Id: FunctionEnum Namespace: hosting.web.task
    public enum FunctionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/close")]
        abuse_close,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/create")]
        abuse_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/create/web")]
        abuse_create_web,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/delete/web")]
        abuse_delete_web,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/update")]
        abuse_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("abuse/update/web")]
        abuse_update_web,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("agora/AnycastUpdateReference")]
        agora_AnycastUpdateReference,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("agora/DnsAddonUpdateReference")]
        agora_DnsAddonUpdateReference,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("agora/DnsUpdateReference")]
        agora_DnsUpdateReference,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("agora/updateReference")]
        agora_updateReference,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedDomain/create")]
        attachedDomain_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedDomain/delete")]
        attachedDomain_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedDomain/restart")]
        attachedDomain_restart,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attachedDomain/update")]
        attachedDomain_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/delete")]
        cdn_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/domain/create")]
        cdn_domain_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/domain/delete")]
        cdn_domain_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/domain/flush")]
        cdn_domain_flush,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/domain/suspend")]
        cdn_domain_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/flush")]
        cdn_flush,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/install")]
        cdn_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/reopen")]
        cdn_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/suspend")]
        cdn_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cdn/upgrade")]
        cdn_upgrade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/setDevelopment")]
        cluster_setDevelopment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/setTesting")]
        cluster_setTesting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/ssl/deploy")]
        cluster_ssl_deploy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/ssl/renew")]
        cluster_ssl_renew,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/attachedDomains")]
        cluster_test_attachedDomains,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/cdn")]
        cluster_test_cdn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/crons")]
        cluster_test_crons,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/emails")]
        cluster_test_emails,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/fileBrowser")]
        cluster_test_fileBrowser,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/hostedssl")]
        cluster_test_hostedssl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/modules")]
        cluster_test_modules,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/ovhConfig")]
        cluster_test_ovhConfig,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/userLogs")]
        cluster_test_userLogs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cluster/test/users")]
        cluster_test_users,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configuration/create")]
        configuration_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configuration/delete")]
        configuration_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("configuration/update")]
        configuration_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cron/create")]
        cron_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cron/delete")]
        cron_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cron/update")]
        cron_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/changePassword")]
        database_changePassword,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/changePasswordTest")]
        database_changePasswordTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/changeRight")]
        database_changeRight,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/changeRightTest")]
        database_changeRightTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/checkQuotaNow")]
        database_checkQuotaNow,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/copy")]
        database_copy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/copyRestore")]
        database_copyRestore,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/create")]
        database_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/delete")]
        database_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/deleteTest")]
        database_deleteTest,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/dumpAnyDay")]
        database_dumpAnyDay,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/hostUpdate")]
        database_hostUpdate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/import")]
        database_import,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/optimize")]
        database_optimize,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("database/restore")]
        database_restore,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedIp/delete")]
        dedicatedIp_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedIp/reopen")]
        dedicatedIp_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedIp/suspend")]
        dedicatedIp_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("depc/push")]
        depc_push,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dump/create")]
        dump_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dump/delete")]
        dump_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("envVar/create")]
        envVar_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("envVar/delete")]
        envVar_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("envVar/update")]
        envVar_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("envVar/upgrade")]
        envVar_upgrade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eventbus/push")]
        eventbus_push,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("filerz/customerMonitoring")]
        filerz_customerMonitoring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("filerz/delete")]
        filerz_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/assignFreeKey")]
        hostedssl_assignFreeKey,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/cdn/update")]
        hostedssl_cdn_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/create")]
        hostedssl_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/delete")]
        hostedssl_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/globalsign/delete")]
        hostedssl_globalsign_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/htaccess/install")]
        hostedssl_htaccess_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/import")]
        hostedssl_import,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/install")]
        hostedssl_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/install/sectigo")]
        hostedssl_install_sectigo,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/iplb/reload")]
        hostedssl_iplb_reload,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/push")]
        hostedssl_push,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/pushDcvFile")]
        hostedssl_pushDcvFile,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/regenerate")]
        hostedssl_regenerate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostedssl/repush")]
        hostedssl_repush,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/activate/privateDatabase")]
        hosting_activate_privateDatabase,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/basculement")]
        hosting_basculement,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/changeOffer/cloud")]
        hosting_changeOffer_cloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/changeOffer/shared")]
        hosting_changeOffer_shared,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/changement")]
        hosting_changement,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/delete")]
        hosting_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/delete_start1m")]
        hosting_delete_start1m,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/install")]
        hosting_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/reopen")]
        hosting_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hosting/suspend")]
        hosting_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("indy/reopen")]
        indy_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("indy/suspend")]
        indy_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/certificate/deploy")]
        infra_certificate_deploy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/certificate/generate")]
        infra_certificate_generate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/certificate/install")]
        infra_certificate_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/sharedsql/upgrade")]
        infra_sharedsql_upgrade,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/ssl/deploy")]
        infra_ssl_deploy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("infra/ssl/renew")]
        infra_ssl_renew,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip/move")]
        ip_move,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip/park")]
        ip_park,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoAccount/create")]
        localSeoAccount_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoAccount/delete")]
        localSeoAccount_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoLocation/delete")]
        localSeoLocation_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoLocation/install")]
        localSeoLocation_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoLocation/reopen")]
        localSeoLocation_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoLocation/suspend")]
        localSeoLocation_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("localSeoVisibilityCheck/process")]
        localSeoVisibilityCheck_process,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mailsout/checkMailsoutQueue")]
        mailsout_checkMailsoutQueue,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mailsout/flushMailsoutQueue")]
        mailsout_flushMailsoutQueue,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mailsout/updateUserInRedis")]
        mailsout_updateUserInRedis,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/copyUsers")]
        migration_copyUsers,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/filerz")]
        migration_dday_filerz,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/listPrivateDatabases")]
        migration_dday_listPrivateDatabases,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/lot")]
        migration_dday_lot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/updateInfra/crons")]
        migration_dday_updateInfra_crons,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/updateInfra/dedicated")]
        migration_dday_updateInfra_dedicated,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/dday/updateInfra/migratedFqdn")]
        migration_dday_updateInfra_migratedFqdn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migration/updateOrt")]
        migration_updateOrt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("module/changePassword")]
        module_changePassword,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("module/create")]
        module_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("module/delete")]
        module_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("module/install")]
        module_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("monitoring/remotewrite")]
        monitoring_remotewrite,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("notification/send")]
        notification_send,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhConfig/refresh")]
        ovhConfig_refresh,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhConfig/rollback")]
        ovhConfig_rollback,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhConfig/update")]
        ovhConfig_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovhOrg/delete")]
        ovhOrg_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownLogs/create")]
        ownLogs_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ownLogs/delete")]
        ownLogs_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/cdn")]
        provisionning_cdn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/cluster")]
        provisionning_cluster,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/filerz")]
        provisionning_filerz,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/filerz_log")]
        provisionning_filerz_log,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/hosting")]
        provisionning_hosting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/ipfo")]
        provisionning_ipfo,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/ipifo")]
        provisionning_ipifo,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/iplb")]
        provisionning_iplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/privatesql")]
        provisionning_privatesql,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/sharedsql")]
        provisionning_sharedsql,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/ssl")]
        provisionning_ssl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/web")]
        provisionning_web,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provisionning/webapp")]
        provisionning_webapp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime/create")]
        runtime_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime/delete")]
        runtime_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime/setDefault")]
        runtime_setDefault,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime/update")]
        runtime_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scan/create")]
        scan_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sqlperso/delete")]
        sqlperso_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sqlperso/install")]
        sqlperso_install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sqlperso/reopen")]
        sqlperso_reopen,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sqlperso/suspend")]
        sqlperso_suspend,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/attachedDomain")]
        synchronizeDepc_attachedDomain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/cluster")]
        synchronizeDepc_cluster,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/database")]
        synchronizeDepc_database,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/filer")]
        synchronizeDepc_filer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/offer")]
        synchronizeDepc_offer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("synchronizeDepc/webd")]
        synchronizeDepc_webd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("test/migration")]
        test_migration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user/changePassword")]
        user_changePassword,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user/create")]
        user_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user/delete")]
        user_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user/update")]
        user_update,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userLogs/changePassword")]
        userLogs_changePassword,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userLogs/create")]
        userLogs_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userLogs/delete")]
        userLogs_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uster/setTesting")]
        uster_setTesting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeDns")]
        web_changeDns,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeFilerz")]
        web_changeFilerz,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeFilerzWithCallback")]
        web_changeFilerzWithCallback,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeJailState")]
        web_changeJailState,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeOutState")]
        web_changeOutState,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeState")]
        web_changeState,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/changeWebState")]
        web_changeWebState,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/checkQuotaNow")]
        web_checkQuotaNow,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/create")]
        web_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/delete")]
        web_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/deleteUser")]
        web_deleteUser,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("web/restoreSnapshot")]
        web_restoreSnapshot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("webProvisionning")]
        webProvisionning,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("webd/changeSlots")]
        webd_changeSlots,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("website/create")]
        website_create,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("website/delete")]
        website_delete,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("website/deploy")]
        website_deploy,
    }
    
    // Id: ObjectTypeEnum Namespace: hosting.web.task
    public enum ObjectTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Abuse")]
        Abuse,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AttachedDomain")]
        AttachedDomain,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BlockedIp")]
        BlockedIp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Cdn")]
        Cdn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Cron")]
        Cron,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Database")]
        Database,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Deployment")]
        Deployment,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Dump")]
        Dump,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("EnvVar")]
        EnvVar,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Filerz")]
        Filerz,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Hostedssl")]
        Hostedssl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Hosting")]
        Hosting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Indy")]
        Indy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Infra")]
        Infra,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Minor")]
        Minor,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Module")]
        Module,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Other")]
        Other,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OvhConfig")]
        OvhConfig,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OvhOrg")]
        OvhOrg,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OwnLogs")]
        OwnLogs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Runtime")]
        Runtime,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Scan")]
        Scan,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Sqlperso")]
        Sqlperso,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("User")]
        User,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UserLogs")]
        UserLogs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Web")]
        Web,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Webd")]
        Webd,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Website")]
        Website,
    }
    
    // Id: StatusEnum Namespace: hosting.web.task
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("init")]
        init,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
}
