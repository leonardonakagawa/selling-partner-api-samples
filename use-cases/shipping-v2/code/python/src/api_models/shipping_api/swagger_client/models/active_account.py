# coding: utf-8

"""
    Amazon Shipping API

    The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.  # noqa: E501

    OpenAPI spec version: v2
    Contact: swa-api-core@amazon.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ActiveAccount(object):
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
        'account_id': 'str',
        'carrier_id': 'CarrierId'
    }

    attribute_map = {
        'account_id': 'accountId',
        'carrier_id': 'carrierId'
    }

    def __init__(self, account_id=None, carrier_id=None):  # noqa: E501
        """ActiveAccount - a model defined in Swagger"""  # noqa: E501
        self._account_id = None
        self._carrier_id = None
        self.discriminator = None
        if account_id is not None:
            self.account_id = account_id
        if carrier_id is not None:
            self.carrier_id = carrier_id

    @property
    def account_id(self):
        """Gets the account_id of this ActiveAccount.  # noqa: E501

        Account Id associated with this account.  # noqa: E501

        :return: The account_id of this ActiveAccount.  # noqa: E501
        :rtype: str
        """
        return self._account_id

    @account_id.setter
    def account_id(self, account_id):
        """Sets the account_id of this ActiveAccount.

        Account Id associated with this account.  # noqa: E501

        :param account_id: The account_id of this ActiveAccount.  # noqa: E501
        :type: str
        """

        self._account_id = account_id

    @property
    def carrier_id(self):
        """Gets the carrier_id of this ActiveAccount.  # noqa: E501


        :return: The carrier_id of this ActiveAccount.  # noqa: E501
        :rtype: CarrierId
        """
        return self._carrier_id

    @carrier_id.setter
    def carrier_id(self, carrier_id):
        """Sets the carrier_id of this ActiveAccount.


        :param carrier_id: The carrier_id of this ActiveAccount.  # noqa: E501
        :type: CarrierId
        """

        self._carrier_id = carrier_id

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
        if issubclass(ActiveAccount, dict):
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
        if not isinstance(other, ActiveAccount):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
