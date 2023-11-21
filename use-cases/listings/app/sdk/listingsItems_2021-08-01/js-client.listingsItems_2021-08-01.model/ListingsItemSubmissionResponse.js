/*
 * Selling Partner API for Listings Items
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](doc:listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
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
import { Issue } from "./Issue.js";

/**
 * The ListingsItemSubmissionResponse model module.
 * @module listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse
 * @version 2021-08-01
 */
export class ListingsItemSubmissionResponse {
  /**
   * Constructs a new <code>ListingsItemSubmissionResponse</code>.
   * Response containing the results of a submission to the Selling Partner API for Listings Items.
   * @alias module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse
   * @class
   * @param sku {String} A selling partner provided identifier for an Amazon listing.
   * @param status {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse.StatusEnum} The status of the listings item submission.
   * @param submissionId {String} The unique identifier of the listings item submission.
   */
  constructor(sku, status, submissionId) {
    this.sku = sku;
    this.status = status;
    this.submissionId = submissionId;
  }

  /**
   * Constructs a <code>ListingsItemSubmissionResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse} obj Optional instance to populate.
   * @return {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse} The populated <code>ListingsItemSubmissionResponse</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ListingsItemSubmissionResponse();
      if (data.hasOwnProperty("sku"))
        obj.sku = ApiClient.convertToType(data["sku"], "String");
      if (data.hasOwnProperty("status"))
        obj.status = ApiClient.convertToType(data["status"], "String");
      if (data.hasOwnProperty("submissionId"))
        obj.submissionId = ApiClient.convertToType(
          data["submissionId"],
          "String",
        );
      if (data.hasOwnProperty("issues"))
        obj.issues = ApiClient.convertToType(data["issues"], [Issue]);
    }
    return obj;
  }
}

/**
 * A selling partner provided identifier for an Amazon listing.
 * @member {String} sku
 */
ListingsItemSubmissionResponse.prototype.sku = undefined;

/**
 * Allowed values for the <code>status</code> property.
 * @enum {String}
 * @readonly
 */
ListingsItemSubmissionResponse.StatusEnum = {
  /**
   * value: "ACCEPTED"
   * @const
   */
  ACCEPTED: "ACCEPTED",

  /**
   * value: "INVALID"
   * @const
   */
  INVALID: "INVALID",
};

/**
 * The status of the listings item submission.
 * @member {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/ListingsItemSubmissionResponse.StatusEnum} status
 */
ListingsItemSubmissionResponse.prototype.status = undefined;

/**
 * The unique identifier of the listings item submission.
 * @member {String} submissionId
 */
ListingsItemSubmissionResponse.prototype.submissionId = undefined;

/**
 * Listings item issues related to the listings item submission.
 * @member {Array.<module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/Issue>} issues
 */
ListingsItemSubmissionResponse.prototype.issues = undefined;
