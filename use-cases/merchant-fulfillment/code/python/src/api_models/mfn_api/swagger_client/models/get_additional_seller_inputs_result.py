# coding: utf-8

"""
    Selling Partner API for Merchant Fulfillment

    The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.  # noqa: E501

    OpenAPI spec version: v0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from src.api_models.mfn_api.swagger_client.configuration import Configuration


class GetAdditionalSellerInputsResult(object):
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
        'shipment_level_fields': 'AdditionalInputsList',
        'item_level_fields_list': 'ItemLevelFieldsList'
    }

    attribute_map = {
        'shipment_level_fields': 'ShipmentLevelFields',
        'item_level_fields_list': 'ItemLevelFieldsList'
    }

    def __init__(self, shipment_level_fields=None, item_level_fields_list=None, _configuration=None):  # noqa: E501
        """GetAdditionalSellerInputsResult - a model defined in Swagger"""  # noqa: E501
        if _configuration is None:
            _configuration = Configuration()
        self._configuration = _configuration

        self._shipment_level_fields = None
        self._item_level_fields_list = None
        self.discriminator = None

        if shipment_level_fields is not None:
            self.shipment_level_fields = shipment_level_fields
        if item_level_fields_list is not None:
            self.item_level_fields_list = item_level_fields_list

    @property
    def shipment_level_fields(self):
        """Gets the shipment_level_fields of this GetAdditionalSellerInputsResult.  # noqa: E501


        :return: The shipment_level_fields of this GetAdditionalSellerInputsResult.  # noqa: E501
        :rtype: AdditionalInputsList
        """
        return self._shipment_level_fields

    @shipment_level_fields.setter
    def shipment_level_fields(self, shipment_level_fields):
        """Sets the shipment_level_fields of this GetAdditionalSellerInputsResult.


        :param shipment_level_fields: The shipment_level_fields of this GetAdditionalSellerInputsResult.  # noqa: E501
        :type: AdditionalInputsList
        """

        self._shipment_level_fields = shipment_level_fields

    @property
    def item_level_fields_list(self):
        """Gets the item_level_fields_list of this GetAdditionalSellerInputsResult.  # noqa: E501


        :return: The item_level_fields_list of this GetAdditionalSellerInputsResult.  # noqa: E501
        :rtype: ItemLevelFieldsList
        """
        return self._item_level_fields_list

    @item_level_fields_list.setter
    def item_level_fields_list(self, item_level_fields_list):
        """Sets the item_level_fields_list of this GetAdditionalSellerInputsResult.


        :param item_level_fields_list: The item_level_fields_list of this GetAdditionalSellerInputsResult.  # noqa: E501
        :type: ItemLevelFieldsList
        """

        self._item_level_fields_list = item_level_fields_list

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
        if issubclass(GetAdditionalSellerInputsResult, dict):
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
        if not isinstance(other, GetAdditionalSellerInputsResult):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, GetAdditionalSellerInputsResult):
            return True

        return self.to_dict() != other.to_dict()