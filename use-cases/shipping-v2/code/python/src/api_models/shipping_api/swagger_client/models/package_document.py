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

class PackageDocument(object):
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
        'type': 'DocumentType',
        'format': 'DocumentFormat',
        'contents': 'Contents'
    }

    attribute_map = {
        'type': 'type',
        'format': 'format',
        'contents': 'contents'
    }

    def __init__(self, type=None, format=None, contents=None):  # noqa: E501
        """PackageDocument - a model defined in Swagger"""  # noqa: E501
        self._type = None
        self._format = None
        self._contents = None
        self.discriminator = None
        self.type = type
        self.format = format
        self.contents = contents

    @property
    def type(self):
        """Gets the type of this PackageDocument.  # noqa: E501


        :return: The type of this PackageDocument.  # noqa: E501
        :rtype: DocumentType
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this PackageDocument.


        :param type: The type of this PackageDocument.  # noqa: E501
        :type: DocumentType
        """
        if type is None:
            raise ValueError("Invalid value for `type`, must not be `None`")  # noqa: E501

        self._type = type

    @property
    def format(self):
        """Gets the format of this PackageDocument.  # noqa: E501


        :return: The format of this PackageDocument.  # noqa: E501
        :rtype: DocumentFormat
        """
        return self._format

    @format.setter
    def format(self, format):
        """Sets the format of this PackageDocument.


        :param format: The format of this PackageDocument.  # noqa: E501
        :type: DocumentFormat
        """
        if format is None:
            raise ValueError("Invalid value for `format`, must not be `None`")  # noqa: E501

        self._format = format

    @property
    def contents(self):
        """Gets the contents of this PackageDocument.  # noqa: E501


        :return: The contents of this PackageDocument.  # noqa: E501
        :rtype: Contents
        """
        return self._contents

    @contents.setter
    def contents(self, contents):
        """Sets the contents of this PackageDocument.


        :param contents: The contents of this PackageDocument.  # noqa: E501
        :type: Contents
        """
        if contents is None:
            raise ValueError("Invalid value for `contents`, must not be `None`")  # noqa: E501

        self._contents = contents

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
        if issubclass(PackageDocument, dict):
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
        if not isinstance(other, PackageDocument):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
