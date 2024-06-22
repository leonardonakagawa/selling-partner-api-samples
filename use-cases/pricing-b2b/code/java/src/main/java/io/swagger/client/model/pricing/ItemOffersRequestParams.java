/*
 * Selling Partner API for Pricing
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model.pricing;

import java.util.Objects;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

/**
 * ItemOffersRequestParams
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2023-12-07T17:09:04.171+01:00")
public class ItemOffersRequestParams {
  @SerializedName("MarketplaceId")
  private String marketplaceId = null;

  @SerializedName("ItemCondition")
  private ItemCondition itemCondition = null;

  @SerializedName("CustomerType")
  private CustomerType customerType = null;

  @SerializedName("Asin")
  private String asin = null;

  public ItemOffersRequestParams marketplaceId(String marketplaceId) {
    this.marketplaceId = marketplaceId;
    return this;
  }

   /**
   * Get marketplaceId
   * @return marketplaceId
  **/
  @ApiModelProperty(required = true, value = "")
  public String getMarketplaceId() {
    return marketplaceId;
  }

  public void setMarketplaceId(String marketplaceId) {
    this.marketplaceId = marketplaceId;
  }

  public ItemOffersRequestParams itemCondition(ItemCondition itemCondition) {
    this.itemCondition = itemCondition;
    return this;
  }

   /**
   * Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club.
   * @return itemCondition
  **/
  @ApiModelProperty(required = true, value = "Filters the offer listings to be considered based on item condition. Possible values: New, Used, Collectible, Refurbished, Club.")
  public ItemCondition getItemCondition() {
    return itemCondition;
  }

  public void setItemCondition(ItemCondition itemCondition) {
    this.itemCondition = itemCondition;
  }

  public ItemOffersRequestParams customerType(CustomerType customerType) {
    this.customerType = customerType;
    return this;
  }

   /**
   * Indicates whether to request Consumer or Business offers. Default is Consumer.
   * @return customerType
  **/
  @ApiModelProperty(value = "Indicates whether to request Consumer or Business offers. Default is Consumer.")
  public CustomerType getCustomerType() {
    return customerType;
  }

  public void setCustomerType(CustomerType customerType) {
    this.customerType = customerType;
  }

  public ItemOffersRequestParams asin(String asin) {
    this.asin = asin;
    return this;
  }

   /**
   * The Amazon Standard Identification Number (ASIN) of the item. This is the same Asin passed as a request parameter.
   * @return asin
  **/
  @ApiModelProperty(value = "The Amazon Standard Identification Number (ASIN) of the item. This is the same Asin passed as a request parameter.")
  public String getAsin() {
    return asin;
  }

  public void setAsin(String asin) {
    this.asin = asin;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ItemOffersRequestParams itemOffersRequestParams = (ItemOffersRequestParams) o;
    return Objects.equals(this.marketplaceId, itemOffersRequestParams.marketplaceId) &&
        Objects.equals(this.itemCondition, itemOffersRequestParams.itemCondition) &&
        Objects.equals(this.customerType, itemOffersRequestParams.customerType) &&
        Objects.equals(this.asin, itemOffersRequestParams.asin);
  }

  @Override
  public int hashCode() {
    return Objects.hash(marketplaceId, itemCondition, customerType, asin);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ItemOffersRequestParams {\n");
    
    sb.append("    marketplaceId: ").append(toIndentedString(marketplaceId)).append("\n");
    sb.append("    itemCondition: ").append(toIndentedString(itemCondition)).append("\n");
    sb.append("    customerType: ").append(toIndentedString(customerType)).append("\n");
    sb.append("    asin: ").append(toIndentedString(asin)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
