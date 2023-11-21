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

/**
 * The Decimal model module.
 * @module listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/Decimal
 * @version 2021-08-01
 */
export class Decimal extends Number {
  /**
   * Constructs a new <code>Decimal</code>.
   * A decimal number with no loss of precision. Useful when precision loss is unnaceptable, as with currencies. Follows RFC7159 for number representation.
   * @alias module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/Decimal
   * @class
   * @param value {Number}
   */
  constructor(value) {
    super(value);
  }

  /**
   * Constructs a <code>Decimal</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/Decimal} obj Optional instance to populate.
   * @return {module:listingsItems_2021-08-01/js-client.listingsItems_2021-08-01.model/Decimal} The populated <code>Decimal</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Decimal(ApiClient.convertToType(data, "Number"));
    }
    return obj;
  }
}
