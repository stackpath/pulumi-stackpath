// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

declare var exports: any;
const __config = new pulumi.Config("stackpath");

export declare const accessToken: string | undefined;
Object.defineProperty(exports, "accessToken", {
    get() {
        return __config.get("accessToken");
    },
    enumerable: true,
});

export declare const baseUrl: string | undefined;
Object.defineProperty(exports, "baseUrl", {
    get() {
        return __config.get("baseUrl");
    },
    enumerable: true,
});

export declare const clientId: string | undefined;
Object.defineProperty(exports, "clientId", {
    get() {
        return __config.get("clientId");
    },
    enumerable: true,
});

export declare const clientSecret: string | undefined;
Object.defineProperty(exports, "clientSecret", {
    get() {
        return __config.get("clientSecret");
    },
    enumerable: true,
});

export declare const stackId: string | undefined;
Object.defineProperty(exports, "stackId", {
    get() {
        return __config.get("stackId");
    },
    enumerable: true,
});

