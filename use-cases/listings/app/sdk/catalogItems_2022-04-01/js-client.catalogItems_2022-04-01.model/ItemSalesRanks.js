/*
 * Selling Partner API for Catalog Items
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
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
import { ItemSalesRanksByMarketplace } from "./ItemSalesRanksByMarketplace.js";

/**
 * The ItemSalesRanks model module.
 * @module catalogItems_2022-04-01/js-client.catalogItems_2022-04-01.model/ItemSalesRanks
 * @version 2022-04-01
 */
export class ItemSalesRanks extends Array {
  /**
   * Constructs a new <code>ItemSalesRanks</code>.
   * Sales ranks of an Amazon catalog item.
   * @alias module:catalogItems_2022-04-01/js-client.catalogItems_2022-04-01.model/ItemSalesRanks
   * @class
   * @extends Array
   */
  constructor() {
    super();
  }

  /**
   * Constructs a <code>ItemSalesRanks</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:catalogItems_2022-04-01/js-client.catalogItems_2022-04-01.model/ItemSalesRanks} obj Optional instance to populate.
   * @return {module:catalogItems_2022-04-01/js-client.catalogItems_2022-04-01.model/ItemSalesRanks} The populated <code>ItemSalesRanks</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new ItemSalesRanks();
      ApiClient.constructFromObject(data, obj, "ItemSalesRanksByMarketplace");
    }
    return obj;
  }
}
