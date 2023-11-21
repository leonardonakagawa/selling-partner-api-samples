/*
 * Selling Partner API for Notifications
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, see the [Notifications Use Case Guide](doc:notifications-api-v1-use-case-guide).
 *
 * OpenAPI spec version: v1
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.9
 *
 * Do not edit the class manually.
 *
 */

import { ApiClient } from "../ApiClient.js";
import { ErrorList } from "./ErrorList.js";
import { Subscription } from "./Subscription.js";

/**
 * The GetSubscriptionResponse model module.
 * @module notifications/js-client.notifications.model/GetSubscriptionResponse
 * @version v1
 */
export class GetSubscriptionResponse {
  /**
   * Constructs a new <code>GetSubscriptionResponse</code>.
   * The response schema for the getSubscription operation.
   * @alias module:notifications/js-client.notifications.model/GetSubscriptionResponse
   * @class
   */
  constructor() {}

  /**
   * Constructs a <code>GetSubscriptionResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:notifications/js-client.notifications.model/GetSubscriptionResponse} obj Optional instance to populate.
   * @return {module:notifications/js-client.notifications.model/GetSubscriptionResponse} The populated <code>GetSubscriptionResponse</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new GetSubscriptionResponse();
      if (data.hasOwnProperty("payload"))
        obj.payload = Subscription.constructFromObject(data["payload"]);
      if (data.hasOwnProperty("errors"))
        obj.errors = ErrorList.constructFromObject(data["errors"]);
    }
    return obj;
  }
}

/**
 * The payload for the getSubscription operation.
 * @member {module:notifications/js-client.notifications.model/Subscription} payload
 */
GetSubscriptionResponse.prototype.payload = undefined;

/**
 * One or more unexpected errors occurred during the getSubscription operation.
 * @member {module:notifications/js-client.notifications.model/ErrorList} errors
 */
GetSubscriptionResponse.prototype.errors = undefined;
