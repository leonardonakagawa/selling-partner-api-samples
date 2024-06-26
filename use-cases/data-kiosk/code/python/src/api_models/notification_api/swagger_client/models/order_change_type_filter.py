# coding: utf-8

"""
    Selling Partner API for Notifications

    The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, see the [Notifications Use Case Guide](doc:notifications-api-v1-use-case-guide).  # noqa: E501

    OpenAPI spec version: v1
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class OrderChangeTypeFilter(object):
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
        'order_change_types': 'OrderChangeTypes'
    }

    attribute_map = {
        'order_change_types': 'orderChangeTypes'
    }

    def __init__(self, order_change_types=None):  # noqa: E501
        """OrderChangeTypeFilter - a model defined in Swagger"""  # noqa: E501
        self._order_change_types = None
        self.discriminator = None
        if order_change_types is not None:
            self.order_change_types = order_change_types

    @property
    def order_change_types(self):
        """Gets the order_change_types of this OrderChangeTypeFilter.  # noqa: E501


        :return: The order_change_types of this OrderChangeTypeFilter.  # noqa: E501
        :rtype: OrderChangeTypes
        """
        return self._order_change_types

    @order_change_types.setter
    def order_change_types(self, order_change_types):
        """Sets the order_change_types of this OrderChangeTypeFilter.


        :param order_change_types: The order_change_types of this OrderChangeTypeFilter.  # noqa: E501
        :type: OrderChangeTypes
        """

        self._order_change_types = order_change_types

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
        if issubclass(OrderChangeTypeFilter, dict):
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
        if not isinstance(other, OrderChangeTypeFilter):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
