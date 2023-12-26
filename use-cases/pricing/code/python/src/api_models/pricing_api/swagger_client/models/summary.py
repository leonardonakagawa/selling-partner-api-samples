# coding: utf-8

"""
    Selling Partner API for Pricing

    The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.  # noqa: E501

    OpenAPI spec version: v0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from src.api_models.pricing_api.swagger_client.configuration import Configuration


class Summary(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'total_offer_count': 'int',
        'number_of_offers': 'NumberOfOffers',
        'lowest_prices': 'LowestPrices',
        'buy_box_prices': 'BuyBoxPrices',
        'list_price': 'MoneyType',
        'competitive_price_threshold': 'MoneyType',
        'suggested_lower_price_plus_shipping': 'MoneyType',
        'sales_rankings': 'SalesRankList',
        'buy_box_eligible_offers': 'BuyBoxEligibleOffers',
        'offers_available_time': 'datetime'
    }

    attribute_map = {
        'total_offer_count': 'TotalOfferCount',
        'number_of_offers': 'NumberOfOffers',
        'lowest_prices': 'LowestPrices',
        'buy_box_prices': 'BuyBoxPrices',
        'list_price': 'ListPrice',
        'competitive_price_threshold': 'CompetitivePriceThreshold',
        'suggested_lower_price_plus_shipping': 'SuggestedLowerPricePlusShipping',
        'sales_rankings': 'SalesRankings',
        'buy_box_eligible_offers': 'BuyBoxEligibleOffers',
        'offers_available_time': 'OffersAvailableTime'
    }

    def __init__(self, total_offer_count=None, number_of_offers=None, lowest_prices=None, buy_box_prices=None, list_price=None, competitive_price_threshold=None, suggested_lower_price_plus_shipping=None, sales_rankings=None, buy_box_eligible_offers=None, offers_available_time=None, _configuration=None):  # noqa: E501
        """Summary - a model defined in Swagger"""  # noqa: E501
        if _configuration is None:
            _configuration = Configuration()
        self._configuration = _configuration

        self._total_offer_count = None
        self._number_of_offers = None
        self._lowest_prices = None
        self._buy_box_prices = None
        self._list_price = None
        self._competitive_price_threshold = None
        self._suggested_lower_price_plus_shipping = None
        self._sales_rankings = None
        self._buy_box_eligible_offers = None
        self._offers_available_time = None
        self.discriminator = None

        self.total_offer_count = total_offer_count
        if number_of_offers is not None:
            self.number_of_offers = number_of_offers
        if lowest_prices is not None:
            self.lowest_prices = lowest_prices
        if buy_box_prices is not None:
            self.buy_box_prices = buy_box_prices
        if list_price is not None:
            self.list_price = list_price
        if competitive_price_threshold is not None:
            self.competitive_price_threshold = competitive_price_threshold
        if suggested_lower_price_plus_shipping is not None:
            self.suggested_lower_price_plus_shipping = suggested_lower_price_plus_shipping
        if sales_rankings is not None:
            self.sales_rankings = sales_rankings
        if buy_box_eligible_offers is not None:
            self.buy_box_eligible_offers = buy_box_eligible_offers
        if offers_available_time is not None:
            self.offers_available_time = offers_available_time

    @property
    def total_offer_count(self):
        """Gets the total_offer_count of this Summary.  # noqa: E501

        The number of unique offers contained in NumberOfOffers.  # noqa: E501

        :return: The total_offer_count of this Summary.  # noqa: E501
        :rtype: int
        """
        return self._total_offer_count

    @total_offer_count.setter
    def total_offer_count(self, total_offer_count):
        """Sets the total_offer_count of this Summary.

        The number of unique offers contained in NumberOfOffers.  # noqa: E501

        :param total_offer_count: The total_offer_count of this Summary.  # noqa: E501
        :type: int
        """
        if self._configuration.client_side_validation and total_offer_count is None:
            raise ValueError("Invalid value for `total_offer_count`, must not be `None`")  # noqa: E501

        self._total_offer_count = total_offer_count

    @property
    def number_of_offers(self):
        """Gets the number_of_offers of this Summary.  # noqa: E501

        A list that contains the total number of offers for the item for the given conditions and fulfillment channels.  # noqa: E501

        :return: The number_of_offers of this Summary.  # noqa: E501
        :rtype: NumberOfOffers
        """
        return self._number_of_offers

    @number_of_offers.setter
    def number_of_offers(self, number_of_offers):
        """Sets the number_of_offers of this Summary.

        A list that contains the total number of offers for the item for the given conditions and fulfillment channels.  # noqa: E501

        :param number_of_offers: The number_of_offers of this Summary.  # noqa: E501
        :type: NumberOfOffers
        """

        self._number_of_offers = number_of_offers

    @property
    def lowest_prices(self):
        """Gets the lowest_prices of this Summary.  # noqa: E501

        A list of the lowest prices for the item.  # noqa: E501

        :return: The lowest_prices of this Summary.  # noqa: E501
        :rtype: LowestPrices
        """
        return self._lowest_prices

    @lowest_prices.setter
    def lowest_prices(self, lowest_prices):
        """Sets the lowest_prices of this Summary.

        A list of the lowest prices for the item.  # noqa: E501

        :param lowest_prices: The lowest_prices of this Summary.  # noqa: E501
        :type: LowestPrices
        """

        self._lowest_prices = lowest_prices

    @property
    def buy_box_prices(self):
        """Gets the buy_box_prices of this Summary.  # noqa: E501

        A list of item prices.  # noqa: E501

        :return: The buy_box_prices of this Summary.  # noqa: E501
        :rtype: BuyBoxPrices
        """
        return self._buy_box_prices

    @buy_box_prices.setter
    def buy_box_prices(self, buy_box_prices):
        """Sets the buy_box_prices of this Summary.

        A list of item prices.  # noqa: E501

        :param buy_box_prices: The buy_box_prices of this Summary.  # noqa: E501
        :type: BuyBoxPrices
        """

        self._buy_box_prices = buy_box_prices

    @property
    def list_price(self):
        """Gets the list_price of this Summary.  # noqa: E501

        The list price of the item as suggested by the manufacturer.  # noqa: E501

        :return: The list_price of this Summary.  # noqa: E501
        :rtype: MoneyType
        """
        return self._list_price

    @list_price.setter
    def list_price(self, list_price):
        """Sets the list_price of this Summary.

        The list price of the item as suggested by the manufacturer.  # noqa: E501

        :param list_price: The list_price of this Summary.  # noqa: E501
        :type: MoneyType
        """

        self._list_price = list_price

    @property
    def competitive_price_threshold(self):
        """Gets the competitive_price_threshold of this Summary.  # noqa: E501

        This price is based on competitive prices from other retailers (excluding other Amazon sellers). The offer may be ineligible for the Buy Box if the seller's price + shipping (minus Amazon Points) is greater than this competitive price.  # noqa: E501

        :return: The competitive_price_threshold of this Summary.  # noqa: E501
        :rtype: MoneyType
        """
        return self._competitive_price_threshold

    @competitive_price_threshold.setter
    def competitive_price_threshold(self, competitive_price_threshold):
        """Sets the competitive_price_threshold of this Summary.

        This price is based on competitive prices from other retailers (excluding other Amazon sellers). The offer may be ineligible for the Buy Box if the seller's price + shipping (minus Amazon Points) is greater than this competitive price.  # noqa: E501

        :param competitive_price_threshold: The competitive_price_threshold of this Summary.  # noqa: E501
        :type: MoneyType
        """

        self._competitive_price_threshold = competitive_price_threshold

    @property
    def suggested_lower_price_plus_shipping(self):
        """Gets the suggested_lower_price_plus_shipping of this Summary.  # noqa: E501

        The suggested lower price of the item, including shipping and Amazon Points. The suggested lower price is based on a range of factors, including historical selling prices, recent Buy Box-eligible prices, and input from customers for your products.  # noqa: E501

        :return: The suggested_lower_price_plus_shipping of this Summary.  # noqa: E501
        :rtype: MoneyType
        """
        return self._suggested_lower_price_plus_shipping

    @suggested_lower_price_plus_shipping.setter
    def suggested_lower_price_plus_shipping(self, suggested_lower_price_plus_shipping):
        """Sets the suggested_lower_price_plus_shipping of this Summary.

        The suggested lower price of the item, including shipping and Amazon Points. The suggested lower price is based on a range of factors, including historical selling prices, recent Buy Box-eligible prices, and input from customers for your products.  # noqa: E501

        :param suggested_lower_price_plus_shipping: The suggested_lower_price_plus_shipping of this Summary.  # noqa: E501
        :type: MoneyType
        """

        self._suggested_lower_price_plus_shipping = suggested_lower_price_plus_shipping

    @property
    def sales_rankings(self):
        """Gets the sales_rankings of this Summary.  # noqa: E501

        A list that contains the sales rank of the item in the given product categories.  # noqa: E501

        :return: The sales_rankings of this Summary.  # noqa: E501
        :rtype: SalesRankList
        """
        return self._sales_rankings

    @sales_rankings.setter
    def sales_rankings(self, sales_rankings):
        """Sets the sales_rankings of this Summary.

        A list that contains the sales rank of the item in the given product categories.  # noqa: E501

        :param sales_rankings: The sales_rankings of this Summary.  # noqa: E501
        :type: SalesRankList
        """

        self._sales_rankings = sales_rankings

    @property
    def buy_box_eligible_offers(self):
        """Gets the buy_box_eligible_offers of this Summary.  # noqa: E501

        A list that contains the total number of offers that are eligible for the Buy Box for the given conditions and fulfillment channels.  # noqa: E501

        :return: The buy_box_eligible_offers of this Summary.  # noqa: E501
        :rtype: BuyBoxEligibleOffers
        """
        return self._buy_box_eligible_offers

    @buy_box_eligible_offers.setter
    def buy_box_eligible_offers(self, buy_box_eligible_offers):
        """Sets the buy_box_eligible_offers of this Summary.

        A list that contains the total number of offers that are eligible for the Buy Box for the given conditions and fulfillment channels.  # noqa: E501

        :param buy_box_eligible_offers: The buy_box_eligible_offers of this Summary.  # noqa: E501
        :type: BuyBoxEligibleOffers
        """

        self._buy_box_eligible_offers = buy_box_eligible_offers

    @property
    def offers_available_time(self):
        """Gets the offers_available_time of this Summary.  # noqa: E501

        When the status is ActiveButTooSoonForProcessing, this is the time when the offers will be available for processing.  # noqa: E501

        :return: The offers_available_time of this Summary.  # noqa: E501
        :rtype: datetime
        """
        return self._offers_available_time

    @offers_available_time.setter
    def offers_available_time(self, offers_available_time):
        """Sets the offers_available_time of this Summary.

        When the status is ActiveButTooSoonForProcessing, this is the time when the offers will be available for processing.  # noqa: E501

        :param offers_available_time: The offers_available_time of this Summary.  # noqa: E501
        :type: datetime
        """

        self._offers_available_time = offers_available_time

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Summary, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Summary):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Summary):
            return True

        return self.to_dict() != other.to_dict()